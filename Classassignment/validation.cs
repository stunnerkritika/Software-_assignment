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
        string code = "";
        /// <summary>
        /// This construcor takes the code and command and vallidates it for further implementation
        /// </summary>
        /// <param name="code"></param>
        /// <param name="command"></param>
        public Validation(string code)
        {
            this.code = code.Trim();
            switch (code)
            {
                case " ":
                    {
                        this.errors = "please enter your code!!";
                        break;
                    }
                default:
                    {
                        if (code.Contains(";"))
                        {
                            string[] code_array = code.Split(';');
                            foreach (string codeBreaked in code_array)
                            {
                                if (codeBreaked != "")
                                {
                                    executing_the_code(codeBreaked.Trim());

                                }


                            }
                        }
                        else
                        {
                            executing_the_code(code);
                        }

                        break;

                    }
            }

        }

        public void executing_the_code(string code)
        {
            string[] code_array = code.Split(' ');
            if (code.Contains("method ") || (code.Contains("(") && code.Contains(")")))
            {
                Method_Implementation mi = new Method_Implementation(code);
                this.errors = mi.error_handling_Method_implementation();
            }
            else if (code.Contains("loop for "))
            {
                Loop_Implementation li = new Loop_Implementation(code);
                this.errors = li.error_handling_loop_implementation();
            }
            else if (code.Contains('=') || code.Contains('+') || code.Contains('%') || code.Contains('-') || code.Contains('/') || code.Contains('*') || code.Contains('<') || code.Contains('>'))
            {
                if (code.Contains("if "))
                {
                    Conditional_implementation ci = new Conditional_implementation(code);
                    this.errors = ci.error_handling_conditional();
                }
                else
                {

                    Varaibles v = new Varaibles(code);
                    this.errors = v.error_handling_varaibles();
                }
            }

            else if (code_array.Length == 2)
            {
                Code_analyzing ca = new Code_analyzing(code_array);
                this.errors = ca.error_handling_Code_analyzing();
            }
            else
            {
                this.errors = "Please enter a valid code syntax";
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



