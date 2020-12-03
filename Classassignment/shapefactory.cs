using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classassignment
{
    public class Shapefactory
    {
        string errors = "";
       /// <summary>
       /// This construcor returns the shape  interface  in respect to user given code.
       /// </summary>
       /// <param name="shape"></param>
       /// <returns></returns>
       public Shapes getShapes(string shape)
        {
            switch(shape){ 
                case "rectangle":
                {
                    return new Rectangle();
                    break;
                }

                case "circle":
                    {
                        return new Circle();
                        break;
                    }
                case "triangle":
                    {
                        return new Triangle();
                        break;
                    }

                default:
                    {
                    return null;
                     break;
                }
            }
        }


    
     /// <summary>
     /// This method returns the error .
     /// </summary>
     /// <returns></returns>
     public string error_from_shapefactory()
    {
        return errors;
    }


    }
   

}
