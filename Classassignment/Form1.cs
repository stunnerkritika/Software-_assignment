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
        bool fill = false;
        SolidBrush Default_Brush = new SolidBrush(Color.Black);
        int initialX = 0;
        int initialY = 0;


        
        public void clear()
        {
            this.label4.Text = " ";
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";

        }
        public void Penswitcher(string color)
        {
            if (!fill)
            {
                switch (color)
                {
                    case "green":
                        {
                            default_pen = new Pen(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            default_pen = new Pen(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            default_pen = new Pen(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            default_pen = new Pen(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            default_pen = new Pen(Color.White);
                            break;
                        }
                    case "red":
                        {
                            default_pen = new Pen(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.label4.Text = "**Pen color not found : " + color + "**";

                            MessageBox.Show("Sorry ! The color " + color + " is not Implemented on the program", "Color Not Found!");
                            break;
                        }
                }

            }
            else
            {
                switch (color)
                {
                    case "green":
                        {
                            Default_Brush = new SolidBrush(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Default_Brush = new SolidBrush(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Default_Brush = new SolidBrush(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Default_Brush = new SolidBrush(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Default_Brush = new SolidBrush(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Default_Brush = new SolidBrush(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.label4.Text = "**Filling color not found : " + color + "**";

                            MessageBox.Show("Sorry ! The color " + color + " is not Implemented on the program", "Color Not Found!");
                            break;
                        }
                }

            }




            this.label4.Text = "color change to:" + color;

        }
        public void fillswitcher(string switched)
        {
            if (switched== "on")
                {
                this.fill = true;
                this.label4.Text = "Fill turned on";

            }
                else if (switched== "off")
                {
                this.fill = false;
                this.label4.Text = "Fill turned off";

            }
                else
            {
                this.label4.Text = "Not a valid command";
            }


        }
        public void moveTo(string positionX , string positionY)
        {
            this.initialX = int.Parse(positionX);
            this.initialY = int.Parse(positionY);
            this.label4.Text = "Initial position moved to (" + positionX + " , " + positionY + ")";
        }

        public void DrawRectangle(string lengths, string breadths)
        {
            try
            {
            
                int length = int.Parse(lengths);
                int breadth = int.Parse(breadths);
                Graphics g = this.pictureBox1.CreateGraphics();
                if (fill)
                {
                    g.FillRectangle(Default_Brush, initialX, initialY, breadth, length);
                }
                else
                {
                    g.DrawRectangle(default_pen, initialX, initialY, breadth, length);
                }
            }
            catch(FormatException e)
            {
                this.label4.Text = "please  enter a valid parameters";
            }
          
            
        }
        public void DrawCircle(string radiuss)
        {
            try
            {
                int radius = int.Parse(radiuss);
                Graphics g = this.pictureBox1.CreateGraphics();

                if (fill)
                {
                    g.FillEllipse(Default_Brush, initialX, initialY, radius * 2, radius * 2);
                }
                else
                {
                    g.DrawEllipse(default_pen, initialX, initialY, radius * 2, radius * 2);
                }
            }
            catch (FormatException e)
            {
                this.label4.Text = "please  enter a valid parameters";
            }





        }
        public void Drawtriangle(string side1,string side2,string side3)
        {
            try
            {
                int sideA = int.Parse(side1);
                int sideB = int.Parse(side2);
                int sideC = int.Parse(side3);
                Graphics g = this.pictureBox1.CreateGraphics();
                Point p1 = new Point(initialX, initialY);
                Point p2 = new Point(sideA, initialY);
                Point p3 = new Point(sideB, sideC);
                Point[] points =
                {
                p1,p2,p3

            };
                if (fill)
                {
                    g.FillPolygon(Default_Brush, points);
                }
                else
                {
                    g.DrawPolygon(default_pen, points);
                }
            }
            catch (FormatException e)
            {
                this.label4.Text = "please  enter a valid parameters";
            }


        }
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
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
    }
}
