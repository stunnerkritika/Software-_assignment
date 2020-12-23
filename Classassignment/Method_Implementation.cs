using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classassignment
{
    public class Method_Implementation
    {

        string errors = "";
        public Method_Implementation(string code)
        {
            if (code.Contains("method ") && code.Contains("(") && code.Contains(")"))
            {
                this.methodExecuting(code);
            }
            else if(code.Contains("(") && code.Contains(")"))
            {
                this.methodCalling(code);
            }
            else
            {
                this.errors = "**There is no such method**";
            }
        }

        public void methodExecuting(string code)
        {
            code = code.Trim();

            string[] breaking_method_in_lines = code.Split('\n');



            string[] breaking_1st_line = breaking_method_in_lines[0].Split('(');


            string[] parameter_recognizer = breaking_1st_line[1].Split(')');

            string[] breaking_down_for_name = breaking_1st_line[0].Split(' ');
            string name_of_method = breaking_down_for_name[1].Trim();
            Data_config.nameOfMethod.Add(name_of_method);
            Data_config.lengthOfMethod.Add(breaking_method_in_lines.Length);
            breaking_method_in_lines[0] = name_of_method;
            Data_config.lineOfCodeInMethod.AddRange(breaking_method_in_lines);
            if (parameter_recognizer[0].Contains("parameter "))
            {
                string parameter = parameter_recognizer[0].Trim();
                string[] parameter_code = parameter.Split(' ');
                string joined_parameter = parameter_code[1];

                Data_config.varaiablesList.Add(joined_parameter);
                Data_config.varaibleValue.Add(0);
                Data_config.index_of_parameter.Add(Data_config.varaiablesList.IndexOf(joined_parameter));

            }
            this.errors = "Method executed : " + name_of_method;
        }

        public void methodCalling(string code)
        {
            Validation v;
            string[] splitting_the_code = code.Split('(');
            for (int x = 0; x < splitting_the_code.Length; x++)
            {
                splitting_the_code[x] = splitting_the_code[x].Trim();
            }
            string[] parameter_recognizer = splitting_the_code[1].Split(')');
            string parameter = parameter_recognizer[0].Trim();



            if (Data_config.nameOfMethod.Contains(splitting_the_code[0]))
            {

                if (Data_config.varaiablesList.Contains(parameter))
                {

                    int index = Data_config.varaiablesList.IndexOf(parameter);
                    int index_of_parameter = (int)Data_config.index_of_parameter[Data_config.nameOfMethod.IndexOf(splitting_the_code[0])];

                    Data_config.varaibleValue[index_of_parameter] = Data_config.varaibleValue[index];

                }


                int index_starting_of_the_method = Data_config.lineOfCodeInMethod.IndexOf(splitting_the_code[0]);
                int length_of_method = (int)Data_config.lengthOfMethod[index_starting_of_the_method];
                for (int i = index_starting_of_the_method + 1; i < length_of_method - 1; i++)
                {
                    v = new Validation((string)Data_config.lineOfCodeInMethod[i]);
                    this.errors = v.error_validation();
                }
            }
        
                
         }
        public string error_handling_Method_implementation()
        {
            return this.errors;
        }
                

    }
}
