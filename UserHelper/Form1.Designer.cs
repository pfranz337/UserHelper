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
            this.programsListBox = new System.Windows.Forms.ListBox();
            this.searchingText = new System.Windows.Forms.TextBox();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.setHelper.SuspendLayout();
            this.popisProgramu.SuspendLayout();
            this.zkratkyKProgramu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seznamZkratek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programsListBox
            // 
            this.programsListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.programsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programsListBox.FormattingEnabled = true;
            this.programsListBox.Location = new System.Drawing.Point(3, 56);
            this.programsListBox.Name = "programsListBox";
            this.programsListBox.ScrollAlwaysVisible = true;
            this.programsListBox.Size = new System.Drawing.Size(339, 498);
            this.programsListBox.Sorted = true;
            this.programsListBox.TabIndex = 0;
            this.programsListBox.SelectedIndexChanged += new System.EventHandler(this.programs_SelectedIndexChanged);
            // 
            // searchingText
            // 
            this.searchingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchingText.Location = new System.Drawing.Point(3, 30);
            this.searchingText.Name = "searchingText";
            this.searchingText.Size = new System.Drawing.Size(339, 20);
            this.searchingText.TabIndex = 1;
            this.searchingText.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // changeHelper
            // 
            this.changeHelper.Location = new System.Drawing.Point(389, 1);
            this.changeHelper.Name = "changeHelper";
            this.changeHelper.Size = new System.Drawing.Size(94, 23);
            this.changeHelper.TabIndex = 4;
            this.changeHelper.Text = "Upravit záznam";
            this.changeHelper.UseVisualStyleBackColor = true;
            this.changeHelper.Click += new System.EventHandler(this.changeHelper_Click);
            // 
            // newHelper
            // 
            this.newHelper.Location = new System.Drawing.Point(296, 1);
            this.newHelper.Name = "newHelper";
            this.newHelper.Size = new System.Drawing.Size(87, 23);
            this.newHelper.TabIndex = 3;
            this.newHelper.Text = "Nový záznam";
            this.newHelper.UseVisualStyleBackColor = true;
            this.newHelper.Click += new System.EventHandler(this.newHelper_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(531, 541);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(158, 37);
            this.save.TabIndex = 2;
            this.save.Text = "Ulož vše";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // setHelper
            // 
            this.setHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setHelper.Controls.Add(this.popisProgramu);
            this.setHelper.Controls.Add(this.zkratkyKProgramu);
            this.setHelper.Location = new System.Drawing.Point(3, 30);
            this.setHelper.Name = "setHelper";
            this.setHelper.SelectedIndex = 0;
            this.setHelper.Size = new System.Drawing.Size(686, 505);
            this.setHelper.TabIndex = 1;
            // 
            // popisProgramu
            // 
            this.popisProgramu.Controls.Add(this.textHelper);
            this.popisProgramu.Location = new System.Drawing.Point(4, 22);
            this.popisProgramu.Name = "popisProgramu";
            this.popisProgramu.Padding = new System.Windows.Forms.Padding(3);
            this.popisProgramu.Size = new System.Drawing.Size(678, 479);
            this.popisProgramu.TabIndex = 0;
            this.popisProgramu.Text = "Popis";
            this.popisProgramu.UseVisualStyleBackColor = true;
            // 
            // textHelper
            // 
            this.textHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textHelper.Location = new System.Drawing.Point(3, 3);
            this.textHelper.Multiline = true;
            this.textHelper.Name = "textHelper";
            this.textHelper.Size = new System.Drawing.Size(672, 473);
            this.textHelper.TabIndex = 0;
            // 
            // zkratkyKProgramu
            // 
            this.zkratkyKProgramu.Controls.Add(this.seznamZkratek);
            this.zkratkyKProgramu.Location = new System.Drawing.Point(4, 22);
            this.zkratkyKProgramu.Name = "zkratkyKProgramu";
            this.zkratkyKProgramu.Padding = new System.Windows.Forms.Padding(3);
            this.zkratkyKProgramu.Size = new System.Drawing.Size(678, 479);
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
            this.seznamZkratek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seznamZkratek.Location = new System.Drawing.Point(3, 3);
            this.seznamZkratek.Name = "seznamZkratek";
            this.seznamZkratek.Size = new System.Drawing.Size(672, 473);
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
            this.programName.Location = new System.Drawing.Point(3, 3);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(287, 20);
            this.programName.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Všechny programy",
            "Uložené programy"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.programsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.searchingText);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.save);
            this.splitContainer1.Panel2.Controls.Add(this.changeHelper);
            this.splitContainer1.Panel2.Controls.Add(this.setHelper);
            this.splitContainer1.Panel2.Controls.Add(this.programName);
            this.splitContainer1.Panel2.Controls.Add(this.newHelper);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 581);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.setHelper.ResumeLayout(false);
            this.popisProgramu.ResumeLayout(false);
            this.popisProgramu.PerformLayout();
            this.zkratkyKProgramu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seznamZkratek)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox programsListBox;
        private System.Windows.Forms.TextBox searchingText;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

