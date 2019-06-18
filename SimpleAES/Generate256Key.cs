using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAES
{
    public partial class Generate256Key : Form
    {
        public Generate256Key()
        {
            InitializeComponent();
        }

        private void Clipboard_Click(object sender, EventArgs e)
        {
            if (chiave.Text == "")
            {

            }
            else
            {
                Clipboard.SetText(chiave.Text);
            }
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            chiave.Text = "";

            RijndaelManaged aesEncryption = new RijndaelManaged();
            aesEncryption.KeySize = 256;
            aesEncryption.BlockSize = 128;
            aesEncryption.Mode = CipherMode.CBC;
            aesEncryption.Padding = PaddingMode.PKCS7;
            aesEncryption.GenerateIV();
            string ivStr = Convert.ToBase64String(aesEncryption.IV);
            aesEncryption.GenerateKey();
            string keyStr = Convert.ToBase64String(aesEncryption.Key);
            //string completeKey = ivStr + "," + keyStr;
            string key = ivStr + keyStr;
            //String key = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(completeKey));

            chiave.Text = key;
        }

        private void Gen_Click_1(object sender, EventArgs e)
        {
            Gen_Click(sender, e);
        }

        private void Clipboard_Click_1(object sender, EventArgs e)
        {
            Clipboard_Click(sender, e);
        }

        private void testocambiato(object sender, EventArgs e)
        {
            if (orig.Text.Length == 0) password.Text = "";
            String text = orig.Text;
            String result = "";
            char[] separator = { '$', '^', '2', '8' };
            if (text.Length > 1)
            {
                String[] parole = text.Split(' ', '\'', ',', '.', '-', '_', ':', ';');

                foreach (String s in parole)
                {
                    if (s.Length > 1)
                    {
                        char[] lettere = s.ToArray();
                        lettere[1] = char.ToUpper(lettere[1]);
                        result += new String(lettere);
                        //result += s.Replace(s[1], char.ToUpper(s[1]));
                        Random r = new Random();
                        result += separator[((Random)r).Next(s.Length%4)];
                    }
                    else
                    {
                        result += s;
                        Random r = new Random();
                        result += separator[((Random)r).Next(s.Length % 4)];
                    }
                }
              
                password.Text = result;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "")
            {

            }
            else
            {
                Clipboard.SetText(password.Text);
            }
        }
    }
}
