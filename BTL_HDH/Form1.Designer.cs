namespace BTL_HDH
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBfile = new System.Windows.Forms.RadioButton();
            this.RBfolder = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnFIndPath = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBfile);
            this.groupBox1.Controls.Add(this.RBfolder);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.BtnFIndPath);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RBfile
            // 
            this.RBfile.AutoSize = true;
            this.RBfile.Location = new System.Drawing.Point(209, 112);
            this.RBfile.Name = "RBfile";
            this.RBfile.Size = new System.Drawing.Size(75, 17);
            this.RBfile.TabIndex = 7;
            this.RBfile.TabStop = true;
            this.RBfile.Text = "Create File";
            this.RBfile.UseVisualStyleBackColor = true;
            this.RBfile.CheckedChanged += new System.EventHandler(this.RBfile_CheckedChanged);
            // 
            // RBfolder
            // 
            this.RBfolder.AutoSize = true;
            this.RBfolder.Checked = true;
            this.RBfolder.Location = new System.Drawing.Point(98, 112);
            this.RBfolder.Name = "RBfolder";
            this.RBfolder.Size = new System.Drawing.Size(88, 17);
            this.RBfolder.TabIndex = 6;
            this.RBfolder.TabStop = true;
            this.RBfolder.Text = "Create Folder";
            this.RBfolder.UseVisualStyleBackColor = true;
            this.RBfolder.CheckedChanged += new System.EventHandler(this.RBfolder_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".html",
            ".cs"});
            this.comboBox1.Location = new System.Drawing.Point(312, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // BtnFIndPath
            // 
            this.BtnFIndPath.AccessibleName = "BtnFindPath";
            this.BtnFIndPath.Location = new System.Drawing.Point(312, 34);
            this.BtnFIndPath.Name = "BtnFIndPath";
            this.BtnFIndPath.Size = new System.Drawing.Size(49, 23);
            this.BtnFIndPath.TabIndex = 4;
            this.BtnFIndPath.Text = "...";
            this.BtnFIndPath.UseVisualStyleBackColor = true;
            this.BtnFIndPath.Click += new System.EventHandler(this.BtnFIndPath_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(98, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(208, 20);
            this.txtPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AccessibleName = "Path";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreate);
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.AccessibleName = "BtnCreateFile";
            this.BtnCreate.Location = new System.Drawing.Point(67, 19);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(97, 23);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleName = "BtnClose";
            this.BtnClose.Location = new System.Drawing.Point(209, 19);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(97, 23);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnFIndPath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton RBfile;
        private System.Windows.Forms.RadioButton RBfolder;
    }
}

