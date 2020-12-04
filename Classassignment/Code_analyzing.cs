using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Code_analyzing
    {
        string errors = "";

        public static bool fill = false;
        public static Pen default_pen = new Pen(Color.Black);
        public static SolidBrush default_brush = new SolidBrush(Color.Black);
        public static int initial_X = 0;
        public static int initial_Y = 0;
        public static Graphics g=Form1.G;

        /// <summary>
        /// This method  takes the code array and  inmplements the user given command code for further running.
        /// </summary>
        /// <param name="code"></param>
        public Code_analyzing(string[] code)
        {
            Command_Implementation ci = new Command_Implementation();

            string firstname = code[0];
            string[] parameters_string = code[1].Split(',');
            Shapefactory shapefactor = new Shapefactory();

            string[] shapes = { "rectangle", "circle", "triangle" };
            string[] otherCommands = { "moveto", "drawto","pen","fill" };

            switch (shapes.Contains(firstname))
            {
                case true:

                    {
                        if (parameters_string.Length == 1||parameters_string.Length== 2 || parameters_string.Length == 3 )
                        {

                            try
                            {
                                int[] parametersInInteger = new int[parameters_string.Length];

                                for (int i = 0; i < parametersInInteger.Length; i++)
                                {
                                    parametersInInteger[i] = int.Parse(parameters_string[i]);
                                }


                                Shapes shape = shapefactor.getShapes(firstname);

                                if(fill)
                                {
                                    shape.getValue(parametersInInteger, default_brush);
                                }
                                else
                                {
                                    shape.getValue(parametersInInteger, default_pen);

                                }
                                shape.Draw(g, initial_X, initial_Y, fill);


                            }
                            catch (Exception e)
                            {
                                this.errors = "Parameter Invalid";
                            }
                            


                        }
                        else
                        {
                            errors = " There must be a length and a breadth";
                        }
                        break;
                    }
                case false :
                    {
                        if(firstname== "moveto")
                        {
                            if (parameters_string.Length == 2)
                            {
                            ci.moveto(parameters_string);
                                this.errors = ci.command_error_handling();
                              
                            }
                            else
                            {
                                this.errors = "Not a valid Syntax";
                            }
                        }
                        else if (firstname=="drawto")
                        {
                            if (parameters_string.Length == 2)
                            {
                                ci.drawto(parameters_string);
                                this.errors = ci.command_error_handling();

                            }
                            else
                            {
                                this.errors = "Not a valid Syntax";
                            }
                        }
                        else if(firstname == "pen")
                        {
                            if (parameters_string.Length == 1)
                            {
                                ci.Penswitcher(parameters_string[0]);
                                this.errors = ci.command_error_handling();

                            }
                            else
                            {
                                this.errors = "Not a valid Syntax";
                            }
                        }
                        else if (firstname == "fill")
                        {
                            if(parameters_string.Length==1)
                            {
                                ci.isfillon(parameters_string);
                                this.errors = ci.command_error_handling();

                            }
                            else
                            {
                                this.errors = "Not a valid Syntax";
                            }

                        }
                        else
                        {
                            this.errors = " There is no such command in the application.";
                        }
                        break;
                    }
            }
        }
/// <summary>
/// This method takes  the errors .
/// </summary>
/// <returns></returns>
        public string error_handling_Code_analyzing()
        {
            return this.errors ;
        }

    }

}
