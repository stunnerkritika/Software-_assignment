using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classassignment
{
    public class Varaibles
    {
        string errors = "";
        string code;
        public Varaibles(string code)
        {
            this.code = code;
            if (code.Contains("="))
            {
                this.variables();
                this.errors = "Varaiable executed";
            }
            else if (code.Contains("+"))
            {
                this.adding_to_the_variables();
            }
            else if (code.Contains("-"))
            {
                this.subtracting_to_the_variables();
            }
            else if (code.Contains("*"))
            {
                this.multiplying_to_the_variables();
            }
            else if (code.Contains("%"))
            {
                this.remaining_to_the_variables();
            }
            else if (code.Contains("/"))
            {
                this.dividing_to_the_variables();
            }
        }

        public void variables()
        {
            string[] code_array = code.Split('=');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {
                    float passed_data = float.Parse(code_array[1]);

                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {

                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        Data_config.varaibleValue[index] = passed_data;
                    }
                    else
                    {
                        Data_config.varaiablesList.Add(code_array[0]);
                        Data_config.varaibleValue.Add(passed_data);

                    }
                }
                catch (Exception)
                {
                   this.errors = "Please pass the number";
                }

            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }


        public void adding_to_the_variables()
        {
            string[] code_array = code.Split('+');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {
                    float passed_data = float.Parse(code_array[1]);
                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_config.varaibleValue[index];

                        float sum_of_data = passed_data + value_of_the_variable;

                        Data_config.varaibleValue[index] = sum_of_data;

                    }
                    else
                    {
                        this.errors = "Not a valid varable name";
                    }



                }
                catch (FormatException fe)
                {
                    this.errors = "Number cannot be added : Is not a number";
                }
            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }


        public void dividing_to_the_variables()
        {
            string[] code_array = code.Split('/');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_config.varaibleValue[index];

                        float sum_of_data = value_of_the_variable /passed_data ;

                        Data_config.varaibleValue[index] = sum_of_data;

                    }
                    else
                    {
                        this.errors = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.errors = "Number cannot be divided : Is not a number";
                }
            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }
        public void multiplying_to_the_variables()
        {
            string[] code_array = code.Split('*');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_config.varaibleValue[index];

                        float sum_of_data = value_of_the_variable * passed_data;

                        Data_config.varaibleValue[index] = sum_of_data;

                    }
                    else
                    {
                        this.errors = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.errors = "Number cannot be multiplyed : Is not a number";
                }
            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }


        public void subtracting_to_the_variables()
        {
            string[] code_array = code.Split('-');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_config.varaibleValue[index];

                        float sum_of_data = value_of_the_variable - passed_data;

                        Data_config.varaibleValue[index] = sum_of_data;

                    }
                    else
                    {
                        this.errors = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.errors = "Number cannot be subtracted : Is not a number";
                }
            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }

        public void remaining_to_the_variables()
        {
            string[] code_array = code.Split('%');
            for (int i = 0; i < code_array.Length; i++)
            {
                code_array[i] = code_array[i].Trim();
            }

            if (code_array.Length == 2)
            {
                try
                {

                    float passed_data = float.Parse(code_array[1]);
                    if (Data_config.varaiablesList.Contains(code_array[0]))
                    {
                        int index = Data_config.varaiablesList.IndexOf(code_array[0]);
                        float value_of_the_variable = (float)Data_config.varaibleValue[index];

                        float sum_of_data = value_of_the_variable % passed_data;

                        Data_config.varaibleValue[index] = sum_of_data;

                    }
                    else
                    {
                        this.errors = "Not a valid varable name";
                    }



                }
                catch (Exception)
                {
                    this.errors = "Number cannot be added : Is not a number";
                }
            }
            else
            {
                this.errors = "Syntax wrong for varaibles";
            }
        }



        public string error_handling_varaibles()
        {
            return errors;
        }
    }
}
