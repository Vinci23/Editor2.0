using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TxtEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            if (btnItalic != null)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (btnUnder != null)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                if (!Directory.Exists(@"c:\Editor"))
                {
                    Directory.CreateDirectory(@"c:\Editor");
                }

                else if(Directory.Exists(@"c:\Editor"))
                 { 

                string path = @"c:\Editor\editor.rtf";
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
                else
                {

                }
            }


            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = @"c:\Editor\editor.rtf";
            StreamReader stream = new StreamReader(path);
            string file = stream.ReadToEnd();
            richTextBox1.Text = file.ToString();
            stream.Close();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void btnUnder_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void btnPlain_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = null;
        }
    }
}
