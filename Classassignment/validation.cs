using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classassignment
{
    public class Validation
    {
        string errors = "";
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
                            Code_analyzing ca = new Code_analyzing(code);
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

        public string error_validation()
        {
            return this.errors;
        }
    }



}



