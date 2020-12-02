using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classassignment
{
    public partial class Form1 : Form
    {
        public static Graphics G;
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
        public void Methodexecuting(string code, string command)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Implementation(this.textBox1.Text, this.textBox2.Text);
            

        }

        public void Implementation(string code , string command)
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
                        Validation ca = new Validation(code,command);
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
    }
}
