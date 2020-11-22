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
        Pen default_pen = new Pen(Color.Black); 
        public void Submitted()

        {
            // MessageBox.Show("Title","Button_click");
            switch (this.textBox1.Text)
            {
                case " ":
                    {
                        this.label4.Text = "please enter your code!!";
                        break;
                    }
                default:
                    {
                        string command = this.textBox2.Text;
                        command=command.ToLower().Trim();
                        switch (command)
                        {
                            case "":
                                {
                                    this.label4.Text = "please enter your Command!!";
                                    break;
                                }
                            case "run":
                                {
                                    this.label4.Text = " ";
                                    Methodexecuting( this.textBox1.Text,this.textBox2.Text);

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
                        break;
                    }
            }
        }
        public void clear()
        {
            this.label4.Text = " ";
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";

        }
        public void DrawRectangle(string lengths, string breadths)
        {
            int length = int.Parse(lengths);
            int breadth = int.Parse(breadths);
            Graphics g = this.pictureBox1.CreateGraphics();
            g.DrawRectangle(default_pen, 0, 0, breadth, length);
        }
        public void DrawCircle(string radiuss)
        {
            int radius = int.Parse(radiuss);
            Graphics g = this.pictureBox1.CreateGraphics();
            g.DrawEllipse(default_pen, 0, 0, radius * 2,radius*2);
           
        }
       public void Drawtriangle(string side1,string side2,string side3)
        {
            int sideA = int.Parse(side1);
            int sideB = int.Parse(side2);
            int sideC = int.Parse(side3);
            Graphics g = this.pictureBox1.CreateGraphics();
            Point p1 = new Point(0,sideA);
            Point p2 = new Point(sideA, sideB);
            Point p3 = new Point(sideB, sideC);
            Point[] points =
            {
                p1,p2,p3

            };
             g.DrawPolygon(default_pen,  points);
        }
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
        }
        public void Methodexecuting(string code,string command)
        {
            code = code.ToLower().Trim();
            string[] codearr = code.Split(' ');
            switch (codearr[0])
            {
                case "rectangle":
                    
                    {
                        if (codearr.Length == 3)
                        {
                            DrawRectangle(codearr[1], codearr[2]);
                        }
                        else
                        {
                            this.label4.Text = " There must be a length and a breadth";
                        }
                        break;
                    }
                case "circle":
                    { 
                        if(codearr.Length==2)
                        {
                            DrawCircle(codearr[1]);
                        }
                        else
                        {
                            this.label4.Text = " There must be  only one radius";

                               
                        }
                        break;
                    }
                case "triangle":
                    {
                      if(codearr.Length==4)
                        {
                            Drawtriangle(codearr[1], codearr[2], codearr[3]);
                          
                        }
                        else
                        {
                            this.label4.Text = "There must be three parameters";
                        }
                        break;

                    }
                    case "pen":
                    {
                        if(codearr.Length==2)
                        {
                         
                        }
                        else
                        {
                            this.label4.Text = "Must be color";
                        }
                        break;
                    }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Submitted();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
