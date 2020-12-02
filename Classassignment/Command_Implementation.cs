using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Command_Implementation
    {
        string error;
        public void isfillon(string[] para)
        {
            if (para[0] == "on")
            {
                Code_analyzing.fill = true;
                this.error = "Fill is turned on";
            }
            else if (para[0]=="off")
            {
                Code_analyzing.fill = false;
                this.error = "Fill is turned off";

            }
            else
            {
                this.error = "Please enter on or off";
            }

        }

        public void Penswitcher(string color)
        {
            if (!Code_analyzing.fill)
            {
                switch (color)
                {
                    case "green":
                        {
                            Code_analyzing.default_pen = new Pen(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Code_analyzing.default_pen = new Pen(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Code_analyzing.default_pen = new Pen(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Code_analyzing.default_pen = new Pen(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Code_analyzing.default_pen = new Pen(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Code_analyzing.default_pen = new Pen(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.error = "**Pen color not found : " + color + "**";
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
                            Code_analyzing.default_brush = new SolidBrush(Color.Green);
                            break;
                        }

                    case "blue":
                        {
                            Code_analyzing.default_brush = new SolidBrush(Color.Blue);
                            break;
                        }
                    case "brown":
                        {
                            Code_analyzing.default_brush = new SolidBrush(Color.Brown);
                            break;
                        }

                    case "yellow":
                        {
                            Code_analyzing.default_brush = new SolidBrush(Color.Yellow);
                            break;
                        }

                    case "white":
                        {
                            Code_analyzing.default_brush = new SolidBrush(Color.White);
                            break;
                        }
                    case "red":
                        {
                            Code_analyzing.default_brush = new SolidBrush(Color.Red);
                            break;
                        }
                    default:
                        {
                            this.error = "**Filling color not found : " + color + "**";
                            break;
                        }
                }

            }
            this.error = "color change to:" + color;

        }

        public void moveto(string[] para)
        {
            try
            {
                int[] parametersInInteger = new int[para.Length];

                for (int i = 0; i < parametersInInteger.Length; i++)
                {
                    parametersInInteger[i] = int.Parse(para[i]);
                }

                Code_analyzing.initial_X = parametersInInteger[0];
                Code_analyzing.initial_Y = parametersInInteger[1];
                this.error = "Intial point changed to " + Code_analyzing.initial_X + "," + Code_analyzing.initial_Y;

            }
            catch (Exception e)
            {
                this.error = "Parameter Invalid";
            }
        }

        public void drawto(string[] para)
        {
            try
            {
                int[] parametersInInteger = new int[para.Length];

                for (int i = 0; i < parametersInInteger.Length; i++)
                {
                    parametersInInteger[i] = int.Parse(para[i]);
                }

                Code_analyzing.g.DrawLine(Code_analyzing.default_pen, Code_analyzing.initial_X, Code_analyzing.initial_Y, parametersInInteger[0], parametersInInteger[1]);

                error = "Line Drawn ";

            }
            catch (Exception e)
            {
                this.error = "Parameter Invalid";
            }
        }

        public string command_error_handling()
        {
            return this.error;
        }
    }
}
