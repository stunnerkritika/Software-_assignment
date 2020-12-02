using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    class Code_analyzing
    {
        string errors = "";

        public static bool fill = false;
        public static Pen default_pen = new Pen(Color.Black);
        public static SolidBrush default_brush = new SolidBrush(Color.Black);

        public Code_analyzing(string[] code)
        {

            string firstname = code[0];
            string[] parameters_string = code[1].Split(',');
            Shapefactory shapefactor = new Shapefactory();
            switch (firstname)
            {
                case "rectangle":

                    {
                        if (parameters_string.Length== 2)
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


                            }
                            catch (Exception e)
                            {
                                this.errors = "Parameter Invalid";
                            }
                            


                            //DrawRectangle(codearr[1], codearr[2]);
                        }
                        else
                        {
                            errors = " There must be a length and a breadth";
                        }
                        break;
                    }
                case "circle":
                    {
                        if (codearr.Length == 2)
                        {
                            //DrawCircle(codearr[1]);
                        }
                        else
                        {
                            errors = " There must be  only one radius";


                        }
                        break;
                    }
                case "triangle":
                    {
                        if (codearr.Length == 4)
                        {
                            //Drawtriangle(codearr[1], codearr[2], codearr[3]);

                        }
                        else
                        {
                            errors = "There must be three parameters";
                        }
                        break;

                    }
                case "pen":
                    {
                        if (codearr.Length == 2)
                        {
                           // Penswitcher(codearr[1]);
                        }
                        else
                        {
                            errors = "Must be color";
                        }
                        break;
                    }
                case "fill":
                    {
                        if (codearr.Length == 2)
                        {
                           // fillswitcher(codearr[1]);

                        }
                        else
                        {
                            errors = " you can only turn off or on the fill!";

                        }
                        break;
                    }
                case "moveto":
                    {
                        if (codearr.Length == 3)
                        {
                            //moveTo(codearr[1], codearr[2]);

                        }
                        else
                        {
                            errors = " you can only turn off or on the fill!";

                        }
                        break;

                    }
            }
        }

        public string error_handling_Code_analyzing()
        {
            return this.errors ;
        }

    }

}
