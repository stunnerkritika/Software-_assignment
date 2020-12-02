using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classassignment
{
    class Code_analyzing
    {


        string errors = "";

        public Code_analyzing(string code)
        {
            code = code.ToLower().Trim();
            string[] codearr = code.Split(' ');
            switch (codearr[0])
            {
                case "rectangle":

                    {
                        if (codearr.Length == 3)
                        {
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
            return this.errors;
        }

    }

}
