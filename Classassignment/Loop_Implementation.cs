using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classassignment
{
    public class Loop_Implementation
    {
        string errors = "";
        
        public Loop_Implementation(string code)
        {

            string[] breaking_lines = code.Split('\n');
            for (int i = 0; i < breaking_lines.Length; i++)
            {
                breaking_lines[i] = breaking_lines[i].Trim();
            }
            string[] breaking_the_first_line = breaking_lines[0].Split(' ');
            if (breaking_the_first_line.Length == 3)
            {
                string varaible_name_given_by_the_user = breaking_the_first_line[breaking_the_first_line.Length - 1].Trim();

                if (Data_config.varaiablesList.Contains(varaible_name_given_by_the_user))
                {
                    this.loopExecution(breaking_lines, varaible_name_given_by_the_user);

                }
                else
                {
                    errors = "**Invalid variable for the loop**";
                }


            }
            else
            {
                errors = "**Loop Syntax error**";
            }
        }

        public void loopExecution(string[] lines, string name_of_varaible)
        {
            int index_of_Varable = Data_config.varaiablesList.IndexOf(name_of_varaible);
            float value_of_the_varable = (float)Data_config.varaibleValue[index_of_Varable];
            Validation vr;

            for (int i = 1; i <= value_of_the_varable; i++)
            {
                for (int x = 1; x < lines.Length - 1; x++)
                {
                    if (!lines[x].Contains("endloop"))
                    {
                        MessageBox.Show(lines[x]);
                        vr = new Validation(lines[x].Trim());
                        errors = vr.error_validation();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public string error_handling_loop_implementation()
        {
            return this.errors;
        }
    }
}
