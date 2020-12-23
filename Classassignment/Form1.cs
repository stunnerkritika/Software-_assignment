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

namespace Classassignment
{
    public partial class Form1 : Form
    {
        public static Graphics G;
        /// <summary>
        /// This method clear the index of textbox and label
        /// </summary>
        public void clear()
        {
            this.label4.Text = " ";
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";

        }

        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
            G = this.pictureBox1.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Implementation(this.textBox1.Text, this.textBox2.Text);


        }
        /// <summary>
        /// this method takes the code and command in string and validate the command and to pass it forther validation
        /// </summary>
        /// <param name="code"></param>
        /// <param name="command"></param>
        public void Implementation(string code, string command)
        {
            command = command.Trim().ToLower();
            code = code.Trim().ToLower();


            switch (command)
            {
                case "":
                    {
                        this.label4.Text = "please enter your Command!!";
                        break;
                    }
                case "run":
                    {
                        Validation ca = new Validation(code);
                        this.label4.Text = ca.error_validation();
                        break;
                    }
                case "clear":
                    {
                        clear();
                        break;

                    }
                case "reset":
                    {
                        clear();
                        this.pictureBox1.Image = null;
                        break;

                    }

                default:
                    {
                        this.label4.Text = " Not a valid command!";
                        break;
                    }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.WriteLine(textBox1.Text);
                write.Close();
                MessageBox.Show("File Saved Successfully");
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Browse file from specified folder";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Filter = "DOCX files (*.docx)|*.docx|All files (*.*)|*.*";

            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //Browse .txt file from computer
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                //displays the text inside the file on TextBox named as txtInput
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);

            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
