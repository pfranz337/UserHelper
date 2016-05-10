using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelper.Model;

namespace UserHelper
{
    public partial class ChooseProg : Form
    {
        
        public ChooseProg()
        {
            InitializeComponent();
        }

        public Cesta_Kontejner Kontejner { get; set; }


        private void ChooseProg_Load(object sender, EventArgs e)
        {
            //pro focus
            t = new Thread(focus);
            t.IsBackground = true;
            t.Start();
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
                    Invoke((MethodInvoker)delegate { Kontejner.cesta = textBox1.Text; textBox1.Text = findProc(id_proc); });
                }
                catch (Exception) { }

                Thread.Sleep(200);
            }
        }

        private string findProc(uint id)
        {
            try
            {
                Process p = Process.GetProcessById((int)id);
                var prom = System.Reflection.Assembly.GetEntryAssembly().Location;
                if (!prom.Equals(p.MainModule.FileName))
                //if (!p.MainModule.FileName.ToUpper().Contains("USERHELPER")) //|| !p.MainModule.FileName.ToUpper().Contains("EXPLORER.EXE"))
                    return p.MainModule.FileName;
                else return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        public string getChooseProgramm() {
            return textBox1.Text;
        }
    }
}
