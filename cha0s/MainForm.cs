using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cha0s
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();

            if (result.ShowDialog() == DialogResult.OK)
            {
                p1.Enabled = true;
                t1.Text = "";
                t1.Text = result.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog result = new OpenFileDialog();

            if (result.ShowDialog() == DialogResult.OK)
            {
                p2.Enabled = true;
                t2.Text = "";
                t2.Text = result.FileName;
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
                    AEScryptdecryptutil.EncryptFile(t1.Text, p1.Text);
                    //MessageBox.Show("Done!");
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
                if (dr == DialogResult.OK)
                {
                    AEScryptdecryptutil.DecryptFile(t2.Text, p2.Text);
                    //MessageBox.Show("Done!");
                }
                else { }
            }
            else MessageBox.Show("Please fill all fields!");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BurningHAM18");
        }
    }
}
