using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Classassignment
{
    public class Conditional_implementation
    {
        string errors = "";
        string code = "";
        public Conditional_implementation(string code)
        {
            MessageBox.Show("I am here");
            this.code = code;
            if (code.Contains('='))
            {
                this.isEqualto_Condition();
            }
            else if (code.Contains('>'))
            {
                this.isGreaterTo_Condition();
            }
            else if (code.Contains('<'))
            {
                this.isLesserto_Condition();
            }
        }

        public void isEqualto_Condition()
        {

            string[] code_splitted = this.code.Split('=');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if (varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_config.varaiablesList.Contains(varaiable_name))
                    {
                        int index = Data_config.varaiablesList.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_config.varaibleValue[index];

                        if (given_number == varaiable_value)
                        {

                            Validation vr;
                            for (int i = 1; i < splitting_using_break_line.Length - 1; i++)
                            {

                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_validation();
                            }
                        }
                    }
                    else
                    {
                        errors = "**No such varaiable found**";
                    }

                }
                catch (FormatException e)
                {
                    errors = "**Please pass a integer value**";
                }



            }
            else
            {
                errors= "**Syntax Error**";
            }
        }


        public void isGreaterTo_Condition()
        {

            string[] code_splitted = this.code.Split('>');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if (varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_config.varaiablesList.Contains(varaiable_name))
                    {
                        int index = Data_config.varaiablesList.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_config.varaibleValue[index];

                        if (varaiable_value > given_number)
                        {

                            Validation vr;
                            for (int i = 1; i < splitting_using_break_line.Length - 1; i++)
                            {
                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_validation();
                            }
                        }
                    }
                    else
                    {
                        errors= "**No such varaiable found**";
                    }

                }
                catch (FormatException e)
                {
                    errors= "**Please pass a integer value greater to**";
                }



            }
            else
            {
                errors = "**Syntax Error**";
            }
        }


        public void isLesserto_Condition()
        {

            string[] code_splitted = this.code.Split('<');

            string varaiable_name_with_if = code_splitted[0].Trim();

            if (varaiable_name_with_if.Contains(' '))
            {

                string[] splitting_varaiable_name_with_if = varaiable_name_with_if.Split(' ');

                string varaiable_name = splitting_varaiable_name_with_if[1].Trim();

                string[] splitting_using_break_line = code_splitted[1].Split('\n');

                try
                {
                    float given_number = float.Parse(splitting_using_break_line[0]);


                    if (Data_config.varaiablesList.Contains(varaiable_name))
                    {
                        int index = Data_config.varaiablesList.IndexOf(varaiable_name);

                        float varaiable_value = (float)Data_config.varaibleValue[index];

                        if (varaiable_value < given_number)
                        {

                            Validation vr;
                            for (int i = 1; i < splitting_using_break_line.Length - 1; i++)
                            {

                                vr = new Validation(splitting_using_break_line[i]);
                                errors = vr.error_validation();
                            }
                        }
                    }
                    else
                    {
                        errors = "**No such varaiable found**";
                    }

                }
                catch (FormatException e)
                {
                    errors= "**Please pass a integer value**";
                }



            }
            else
            {
                errors= "**Syntax Error**";
            }
        }

        public string error_handling_conditional()
        {
            return this.errors;
        }
    }
}
