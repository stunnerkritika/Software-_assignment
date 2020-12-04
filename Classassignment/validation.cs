using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classassignment
{
   
    public class Validation
    {
        string errors = "";
       /// <summary>
       /// This construcor takes the code and command and vallidates it for further implementation
       /// </summary>
       /// <param name="code"></param>
       /// <param name="command"></param>
       public Validation(string code ,string command) {
            switch (code)
            {
               case " ":
                    {
                        this.errors = "please enter your code!!";
                        break;
                    }
                default:
                    {

                        string[] code_array = code.Split(' ');
                        if(code_array.Length == 2)
                        {
                            Code_analyzing ca = new Code_analyzing(code_array);
                            this.errors = ca.error_handling_Code_analyzing();
                        }
                        else
                        {
                            this.errors = "Please enter a valid code syntax";
                        }
                        break;
                    }
            }

        }

        /// <summary>
        /// This mnethod returns the error.
        /// </summary>
        /// <returns></returns>
        public string error_validation()
        {
            return this.errors;
        }
    }



}



