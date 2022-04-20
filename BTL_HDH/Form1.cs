using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtName.Enabled = false;
            BtnCreate.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void BtnFIndPath_Click(object sender, EventArgs e)
        {
            //vvvvvvvvvvvvvvvv
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    txtPath.Text = fbd.SelectedPath; //Gan duong dan
                    RichTextBox textBox = new RichTextBox();

                    if(txtName.Text != null)
                    {
                        txtName.Enabled = true;
                        BtnCreate.Enabled = true;
                    }
                }
            }
        }

        private void RBfolder_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }
        private void RBfile_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void BtnCreateFile_Click(object sender, EventArgs e)//btn create file
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            String link;
            // Create Folder
            if (RBfolder.Checked == true)
            {    
                link = txtPath.Text + "/" + txtName.Text;

                if (Directory.Exists(link))
                {
                    MessageBox.Show("Folder already exist");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(link);//du lieu trong textbox name);

                    if (Directory.Exists(link))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("Error! Something went wrong.");
                    }
                }
            }
            // Create File
            else if (RBfile.Checked == true)
            {
                link = txtPath.Text + "/" + txtName.Text + comboBox1.SelectedItem;

                if(comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("You need to choose file type");
                }
                else
                {
                    if (File.Exists(link))
                    {
                        MessageBox.Show("File already exist");
                    }
                    else
                    {
                        File.Create(link);

                        if (File.Exists(link))
                        {
                            MessageBox.Show("Success");
                        }
                        else
                        {
                            MessageBox.Show("Error! Something went wrong.");
                        }
                    }
                }
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
