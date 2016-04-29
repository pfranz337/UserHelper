namespace UserHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.programs = new System.Windows.Forms.ListBox();
            this.searchingText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeHelper = new System.Windows.Forms.Button();
            this.newHelper = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.setHelper = new System.Windows.Forms.TabControl();
            this.popisProgramu = new System.Windows.Forms.TabPage();
            this.textHelper = new System.Windows.Forms.TextBox();
            this.zkratkyKProgramu = new System.Windows.Forms.TabPage();
            this.seznamZkratek = new System.Windows.Forms.DataGridView();
            this.Zkratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.setHelper.SuspendLayout();
            this.popisProgramu.SuspendLayout();
            this.zkratkyKProgramu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seznamZkratek)).BeginInit();
            this.SuspendLayout();
            // 
            // programs
            // 
            this.programs.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.programs.FormattingEnabled = true;
            this.programs.Location = new System.Drawing.Point(12, 64);
            this.programs.Name = "programs";
            this.programs.ScrollAlwaysVisible = true;
            this.programs.Size = new System.Drawing.Size(196, 420);
            this.programs.Sorted = true;
            this.programs.TabIndex = 0;
            this.programs.SelectedIndexChanged += new System.EventHandler(this.programs_SelectedIndexChanged);
            // 
            // searchingText
            // 
            this.searchingText.Location = new System.Drawing.Point(12, 38);
            this.searchingText.Name = "searchingText";
            this.searchingText.Size = new System.Drawing.Size(196, 20);
            this.searchingText.TabIndex = 1;
            this.searchingText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeHelper);
            this.panel1.Controls.Add(this.newHelper);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.setHelper);
            this.panel1.Controls.Add(this.programName);
            this.panel1.Location = new System.Drawing.Point(214, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 482);
            this.panel1.TabIndex = 2;
            // 
            // changeHelper
            // 
            this.changeHelper.Location = new System.Drawing.Point(389, 8);
            this.changeHelper.Name = "changeHelper";
            this.changeHelper.Size = new System.Drawing.Size(94, 23);
            this.changeHelper.TabIndex = 4;
            this.changeHelper.Text = "Upravit záznam";
            this.changeHelper.UseVisualStyleBackColor = true;
            this.changeHelper.Click += new System.EventHandler(this.changeHelper_Click);
            // 
            // newHelper
            // 
            this.newHelper.Location = new System.Drawing.Point(296, 8);
            this.newHelper.Name = "newHelper";
            this.newHelper.Size = new System.Drawing.Size(87, 23);
            this.newHelper.TabIndex = 3;
            this.newHelper.Text = "Nový záznam";
            this.newHelper.UseVisualStyleBackColor = true;
            this.newHelper.Click += new System.EventHandler(this.newHelper_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(738, 440);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 39);
            this.save.TabIndex = 2;
            this.save.Text = "Ulož vše";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // setHelper
            // 
            this.setHelper.Controls.Add(this.popisProgramu);
            this.setHelper.Controls.Add(this.zkratkyKProgramu);
            this.setHelper.Enabled = false;
            this.setHelper.Location = new System.Drawing.Point(3, 34);
            this.setHelper.Name = "setHelper";
            this.setHelper.SelectedIndex = 0;
            this.setHelper.Size = new System.Drawing.Size(839, 404);
            this.setHelper.TabIndex = 1;
            // 
            // popisProgramu
            // 
            this.popisProgramu.Controls.Add(this.textHelper);
            this.popisProgramu.Location = new System.Drawing.Point(4, 22);
            this.popisProgramu.Name = "popisProgramu";
            this.popisProgramu.Padding = new System.Windows.Forms.Padding(3);
            this.popisProgramu.Size = new System.Drawing.Size(831, 378);
            this.popisProgramu.TabIndex = 0;
            this.popisProgramu.Text = "Popis";
            this.popisProgramu.UseVisualStyleBackColor = true;
            // 
            // textHelper
            // 
            this.textHelper.Location = new System.Drawing.Point(0, 0);
            this.textHelper.Multiline = true;
            this.textHelper.Name = "textHelper";
            this.textHelper.Size = new System.Drawing.Size(831, 378);
            this.textHelper.TabIndex = 0;
            // 
            // zkratkyKProgramu
            // 
            this.zkratkyKProgramu.Controls.Add(this.seznamZkratek);
            this.zkratkyKProgramu.Location = new System.Drawing.Point(4, 22);
            this.zkratkyKProgramu.Name = "zkratkyKProgramu";
            this.zkratkyKProgramu.Padding = new System.Windows.Forms.Padding(3);
            this.zkratkyKProgramu.Size = new System.Drawing.Size(831, 378);
            this.zkratkyKProgramu.TabIndex = 1;
            this.zkratkyKProgramu.Text = "Klávesové zkratky";
            this.zkratkyKProgramu.UseVisualStyleBackColor = true;
            // 
            // seznamZkratek
            // 
            this.seznamZkratek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seznamZkratek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zkratka,
            this.Popis});
            this.seznamZkratek.Location = new System.Drawing.Point(0, 0);
            this.seznamZkratek.Name = "seznamZkratek";
            this.seznamZkratek.Size = new System.Drawing.Size(828, 382);
            this.seznamZkratek.TabIndex = 0;
            // 
            // Zkratka
            // 
            this.Zkratka.HeaderText = "Zkratka";
            this.Zkratka.Name = "Zkratka";
            // 
            // Popis
            // 
            this.Popis.HeaderText = "Popis";
            this.Popis.Name = "Popis";
            // 
            // programName
            // 
            this.programName.Location = new System.Drawing.Point(3, 8);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(287, 20);
            this.programName.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Všechny programy",
            "Uložené programy"});
            this.comboBox1.Location = new System.Drawing.Point(12, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 498);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchingText);
            this.Controls.Add(this.programs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.setHelper.ResumeLayout(false);
            this.popisProgramu.ResumeLayout(false);
            this.popisProgramu.PerformLayout();
            this.zkratkyKProgramu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seznamZkratek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox programs;
        private System.Windows.Forms.TextBox searchingText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TabControl setHelper;
        private System.Windows.Forms.TabPage popisProgramu;
        private System.Windows.Forms.TabPage zkratkyKProgramu;
        private System.Windows.Forms.TextBox programName;
        private System.Windows.Forms.DataGridView seznamZkratek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zkratka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popis;
        private System.Windows.Forms.TextBox textHelper;
        private System.Windows.Forms.Button changeHelper;
        private System.Windows.Forms.Button newHelper;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

