﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{ 
    /// <summary>
    /// This class implements the command.
    /// </summary>
    public class Command_Implementation
    {
        string error;

        /// <summary>
        /// This method is to turn on or off the filling according to user command given implements .
        /// </summary>
        /// <param name="para"></param>
        public void isfillon(string[] para)
        {
            if (para[0] == "on")
            {
                Code_analyzing.fill = true;
                this.error = "Fill is turned on";
            }
            else if (para[0] == "off")
            {
                Code_analyzing.fill = false;
                this.error = "Fill is turned off";

            }
            else
            {
                this.error = "Please enter on or off";
            }

        }

        /// <summary>
        /// This method takes the string color and converts the pen or brush used for drawing.
        /// </summary>
        /// <param name="color"></param>
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
        /// <summary>
        /// This method moves the initial position x and y  to the user givan parameter.
        /// </summary>
        /// <param name="para"></param>
        public void moveto(string[] para)
        {
            try
            {
                float[] parametersInInteger = new float[para.Length];

                for (int i = 0; i < parametersInInteger.Length; i++)
                { if (Data_config.varaiablesList.Contains(para[i]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(para[i]);
                        parametersInInteger[i] = (float)Data_config.varaibleValue[index];
                    }
                    else
                    {
                        parametersInInteger[i] = float.Parse(para[i]);

                    }
                }

                Code_analyzing.initial_X = (int)parametersInInteger[0];
                Code_analyzing.initial_Y =(int) parametersInInteger[1];
                this.error = "Intial point changed to " + Code_analyzing.initial_X + "," + Code_analyzing.initial_Y;

            }
            catch (Exception e)
            {
                this.error = e.Message;
            }
        }
        /// <summary>
        /// This method  draw the line from initial  positions to the user given point
        /// </summary>
        /// <param name="para"></param>
        public void drawto(string[] para)
        {
            try
            {

                float[] parametersInInteger = new float[para.Length];

                for (int i = 0; i < parametersInInteger.Length; i++)
                {
                    if (Data_config.varaiablesList.Contains(para[i]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(para[i]);
                        parametersInInteger[i] = (float)Data_config.varaibleValue[index];
                    }
                    else
                    {
                        parametersInInteger[i] = float.Parse(para[i]);

                    }
                }

                Code_analyzing.g.DrawLine(Code_analyzing.default_pen, Code_analyzing.initial_X, Code_analyzing.initial_Y, parametersInInteger[0], parametersInInteger[1]);

                error = "Line Drawn ";

            }
            catch (Exception e)
            {
                this.error = e.Message;
            }
        }
        /// <summary>
        /// This returns the erros in the code implement class.
        /// </summary>
        /// <returns></returns>
        public string command_error_handling()
        {
            return this.error;
        }
    }
}
