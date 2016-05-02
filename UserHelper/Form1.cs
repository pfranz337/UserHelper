﻿using Microsoft.Win32;
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

namespace UserHelper
{
    public partial class Form1 : Form
    {

        List<string> seznamProgramu;
        string helperFileName = Environment.CurrentDirectory + "\\helper.ini";
        IniFile fileIniHelper;
        

        public Form1()
        {
            seznamProgramu = new List<string>();
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        try
                        {
                            var name = subkey.GetValue("DisplayName");
                            programs.Items.Add(name);
                            seznamProgramu.Add(name as string);
                        }
                        catch (ArgumentNullException ee) { }
                    }
                }
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            programs.Items.Clear();
            if (searchingText.Text.Equals("")) { programs.Items.AddRange(seznamProgramu.ToArray()); }
            else
            {
                var search = seznamProgramu.FindAll(X => X.ToUpper().Contains(searchingText.Text.ToUpper()));
                programs.Items.AddRange(search.ToArray());
            }
        }

        private void programs_SelectedIndexChanged(object sender, EventArgs e)
        {
            programName.Text = (sender as ListBox).SelectedItem as string;
            setHelper.Enabled = false;
        }

        private void newHelper_Click(object sender, EventArgs e)
        {
            setHelper.Enabled = true;
            fileIniHelper = new IniFile(helperFileName);             
            var seznamProgramu = fileIniHelper.GetSectionNames();
            if (seznamProgramu.ToList().Contains(programName.Text.ToUpper())) {
                DialogResult = MessageBox.Show("Program již má uložené hodnoty. Přepsat???", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No) setHelper.Enabled = false;
                if (DialogResult == DialogResult.Yes) {
                    textHelper.Text = "";
                    seznamZkratek.Rows.Clear();
                    fileIniHelper.deleteWholeSection(programName.Text.ToUpper());
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {                                    
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
                    if (cell.Value != null) {
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

        private void zapisIni(string sekce, string par_popis, string par_zkratky) {
            StreamWriter zapisDoIni = new StreamWriter(helperFileName, true);
            zapisDoIni.WriteLine(sekce);
            zapisDoIni.WriteLine(par_popis);
            zapisDoIni.WriteLine(par_zkratky);
            zapisDoIni.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) textBox1_TextChanged(sender, e);
            if (comboBox1.SelectedIndex == 1) ulozeneProgramy();
        }

        private void ulozeneProgramy() {
            programs.Items.Clear();
            fileIniHelper = new IniFile(helperFileName);
            var programy = fileIniHelper.GetSectionNames();
            programs.Items.AddRange(programy);
        }

        private void changeHelper_Click(object sender, EventArgs e)
        {
            setHelper.Enabled = true;
            fileIniHelper = new IniFile(helperFileName);
            var seznamProgramu = fileIniHelper.GetSectionNames();
            if (seznamProgramu.ToList().Contains(programName.Text.ToUpper()))
            {
                textHelper.Text = fileIniHelper.IniReadValue(programName.Text.ToUpper(),"POPIS");
                string zkratky = fileIniHelper.IniReadValue(programName.Text.ToUpper(), "ZKRATKY");
                var arrayZkratky = zkratky.Split('\\');
                for (int i = 0; i < arrayZkratky.Length-1; i++) {
                    var zkratka_popis = arrayZkratky[i].Split('-');
                    seznamZkratek.Rows.Add(zkratka_popis[0], zkratka_popis[1]);
                }

            }
            else {
                MessageBox.Show("Program ještě není uložen.");
                setHelper.Enabled = false;
            }
        }
    }
}