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

namespace cha0s
{
    public partial class MainForm : Form
    {
        string[] tempE;
        string[] tempD;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Multiselect = true;
            if (result.ShowDialog() == DialogResult.OK)
            {
                p1.Enabled = true;
                t1.Text = "";
                tempE = result.FileNames;
                foreach(string s in tempE)
                {
                    t1.Text += "\""+Path.GetFileName(s)+"\" ";
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();
            result.Multiselect = true;

            if (result.ShowDialog() == DialogResult.OK)
            {
                p2.Enabled = true;
                t2.Text = "";
                tempD = result.FileNames;
                foreach (string s in tempD)
                {
                    t2.Text += "\"" + Path.GetFileName(s) + "\" ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1.Text != "" && t1.Text != "")
            {

                DialogResult dr = new DialogResult();
                AreYouUSureD form1 = new AreYouUSureD();
                dr = form1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    foreach (string s in tempE)
                    {
                        AEScryptdecryptutil.EncryptFile(s, p1.Text);
                    }

                    MessageBox.Show("Encryption Succesful!");
                }
                else if (dr == DialogResult.Cancel)
                { }
                
                
            }
            else MessageBox.Show("Please fill all fields!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p2.Text != "" && t2.Text != "")
            {
                DialogResult dr = new DialogResult();
                AreYouSureD form2 = new AreYouSureD();
                dr = form2.ShowDialog();
                bool control=false;
                if (dr == DialogResult.OK)
                {
                    foreach (string s in tempD)
                    {

                        try { control = AEScryptdecryptutil.DecryptFile(s, p2.Text); }
                        catch(UnauthorizedAccessException e1)
                        {
                            control = false;

                            if (Directory.Exists(Path.GetDirectoryName(s) + "\\Decrypted")) Directory.Delete(Path.GetDirectoryName(s) + "\\Decrypted", true);
                        }
                        if (control == false) break;
                    }
                    if (control == true) MessageBox.Show("Decryption Succesful!");
                }
                else { }
            }
            else MessageBox.Show("Please fill all fields!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BurningHAM18");
        }

        private void onload(object sender, EventArgs e)
        {
           
            String[] argument = Environment.GetCommandLineArgs();
            try
            {
                if (argument[1] == null)
                {
                    
                }
                else
                {
                    tempE = new String[1];
                    tempD = new String[1];
                    tempE[0] = argument[1];
                    tempD[0] = argument[1];

                    t1.Text = Path.GetFileName(argument[1]);
                    t2.Text = Path.GetFileName(argument[1]);

                    p1.Enabled = true;
                    p2.Enabled = true;

                }
            }
            catch (Exception e8)
            {
                // iolo
            }
        
        }
    }
}
