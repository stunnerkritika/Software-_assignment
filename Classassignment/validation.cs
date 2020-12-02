using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classassignment
{
    public class validation
    {
        string errors = "";
        public validation(string code ,string command) {
            switch (code)
            {
               case " ":
                    {
                        this.errors = "please enter your code!!";
                        break;
                    }
                default:
                    {
                        switch (command)
                        {
                            case "":
                                {
                                    this.errors = "please enter your Command!!";
                                    break;
                                }
                            case "run":
                                {
                                    Code_analyzing ca = new Code_analyzing(code);
                                    this.errors = ca.error_handling_Code_analyzing();

                                    break;
                                }
                            case "clear":
                                {
                                    //clear();
                                    break;

                                }
                            case "reset":
                                {
                                   // clear();
                                   // this.pictureBox1.Image = null;
                                    break;

                                }

                            default:
                                {
                                    this.errors = " Not a valid command!";
                                    break;
                                }
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



