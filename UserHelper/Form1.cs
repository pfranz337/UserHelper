using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;
using UserHelper.Model;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UserHelper
{
    public partial class Form1 : Form
    {
        BindingSource source = new BindingSource();
        List<string> seznamProgramu;
        //TODO: je potřeba získat i cesty k exe souborům, názvy nestačí vytvořená třída WatchableApplication

        string helperFileName = Environment.CurrentDirectory + "\\helper.ini";
        IniFile fileIniHelper;

        public void Test()
        {
            var app1 = new WatchableApplication
            {
                Name = @"asdf\n|€&#&App1</větší než > menší!!::/\÷¤ß$Łł",
                ExeLocation = @"c:\Uses\Tom\",
                RecordContent =
                    new Record()
                    {
                        Content = new RichContent
                        {
                            Language = "cs-CZ",
                            Text = "Ahoj tohle je testovací text pro app1"
                        },
                        Shortcuts = new List<KeyShortcut>{
                            new KeyShortcut {
                                Action ="Kopírovat",
                                Keys = new HashSet<Keys>{Keys.Control, Keys.C}
                            },
                        }
                    }
            };

            app1.SaveToXmlFile("textfile.xml");
        }


        public Form1()
        {
            seznamProgramu = new List<string>();
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            source.DataSource = seznamProgramu;
            programsListBox.DataSource = source;

            Test();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getListPrograms();

            //pro focus
            t = new Thread(focus);
            t.IsBackground = true;
            t.Start();
        }

        private void getListPrograms()
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        var name = subkey.GetValue("DisplayName") as string;
                        if (name != null)
                        {
                            seznamProgramu.Add(name);
                        }
                    }
                }
            }
            source.ResetBindings(false);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            source.DataSource = seznamProgramu.FindAll(x => x.ToLower().Contains(searchingText.Text.ToLower()));
            source.ResetBindings(false);
        }

        private void programs_SelectedIndexChanged(object sender, EventArgs e)
        {
            programName.Text = (sender as ListBox).SelectedItem.ToString();
            //setHelper.Enabled = false;
        }

        private void newHelper_Click(object sender, EventArgs e)
        {
            //setHelper.Enabled = true;
            seznamZkratek.ReadOnly = false;
            textHelper.ReadOnly = false;
            fileIniHelper = new IniFile(helperFileName);
            var seznamProgramu = fileIniHelper.GetSectionNames();
            if (seznamProgramu.ToList().Contains(programName.Text.ToUpper()))
            {
                DialogResult = MessageBox.Show("Program již má uložené hodnoty. Přepsat???", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No) setHelper.Enabled = false;
                if (DialogResult == DialogResult.Yes)
                {
                    textHelper.Text = "";
                    seznamZkratek.Rows.Clear();
                    fileIniHelper.deleteWholeSection(programName.Text.ToUpper());
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            seznamZkratek.ReadOnly = true;
            textHelper.ReadOnly = true;

            string sekce = "[" + programName.Text.ToUpper() + "]";

            fileIniHelper = new IniFile(helperFileName);
            if (fileIniHelper.GetSectionNames().ToList().Contains(programName.Text.ToUpper()))
                fileIniHelper.deleteWholeSection(programName.Text.ToUpper());

            string par_popis = "POPIS=";
            string par_zkratky = "ZKRATKY=";

            if (!textHelper.Text.Equals("")) par_popis += textHelper.Text;
            foreach (DataGridViewRow row in seznamZkratek.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (!cell.Value.ToString().Equals(""))
                        {
                            par_zkratky += row.Cells[0].Value.ToString() + "-" + row.Cells[1].Value.ToString() + @"\";
                            break;
                        }
                    }
                }
            }

            zapisIni(sekce, par_popis, par_zkratky);

            programName.Text = "";
            textHelper.Text = "";
            seznamZkratek.Rows.Clear();
        }

        private void zapisIni(string sekce, string par_popis, string par_zkratky)
        {
            StreamWriter zapisDoIni = new StreamWriter(helperFileName, true);
            zapisDoIni.WriteLine(sekce);
            zapisDoIni.WriteLine(par_popis);
            zapisDoIni.WriteLine(par_zkratky);
            zapisDoIni.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) SearchTextBox_TextChanged(sender, e);
            if (comboBox1.SelectedIndex == 1) ulozeneProgramy();
        }

        private void ulozeneProgramy()
        {
            fileIniHelper = new IniFile(helperFileName);
            var programy = fileIniHelper.GetSectionNames();

            source.DataSource = programy;
            source.ResetBindings(true);
        }

        private void changeHelper_Click(object sender, EventArgs e)
        {
            seznamZkratek.Rows.Clear();

            seznamZkratek.ReadOnly = false;
            textHelper.ReadOnly = false;


            if (seznamProgramu.ToList().Contains(programName.Text.ToUpper()))
            {
                getDataFromINI();
            }
            else {
                MessageBox.Show("Program ještě není uložen.");
                setHelper.Enabled = false;
            }
        }

        private void getDataFromINI()
        {
            fileIniHelper = new IniFile(helperFileName);
            var seznamProgramu = fileIniHelper.GetSectionNames();
            textHelper.Text = fileIniHelper.IniReadValue(programName.Text.ToUpper(), "POPIS");
            string zkratky = fileIniHelper.IniReadValue(programName.Text.ToUpper(), "ZKRATKY");
            var arrayZkratky = zkratky.Split('\\');
            for (int i = 0; i < arrayZkratky.Length - 1; i++)
            {
                var zkratka_popis = arrayZkratky[i].Split('-');
                seznamZkratek.Rows.Add(zkratka_popis[0], zkratka_popis[1]);
            }
        }

        private void programName_TextChanged(object sender, EventArgs e)
        {
            seznamZkratek.Rows.Clear();
            if (!programName.Text.Equals(""))
            {
                getDataFromINI();
            }
        }



        //------------------FOCUS ON WINDOW---------------------------------------------------
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private uint GetActiveWindowTitle()
        {
            const int nChars = 256;
            uint id;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowThreadProcessId(handle, out id) > 0)
            {
                return id;
            }
            return 0;
        }

        Thread t;

        private void focus()
        {
            while (true)
            {
                uint id_proc = GetActiveWindowTitle();

                try
                {
                    Invoke((MethodInvoker)delegate { label1.Text = findProc(id_proc); });
                }
                catch (Exception) { }

                Thread.Sleep(200);
            }
        }

        private string findProc(uint id)
        {
            try { 
            Process p = Process.GetProcessById((int)id);
            return p.MainModule.FileName;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


    }
}
