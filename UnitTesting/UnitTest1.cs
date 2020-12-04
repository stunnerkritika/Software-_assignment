using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Drawing;
using System.IO;

namespace Classassignment.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_forValidation()
        {

            //checking the validation by passing through the empty string to the command and running it 
            string given_empty_input_code = "";
            string given_run_command = "run";

            Validation v = new Validation(given_empty_input_code, given_run_command);
            string output_given_by_class = v.error_validation();

            string expected_output = "Please enter a valid code syntax";

            Assert.AreEqual(expected_output, output_given_by_class);
        }

    }
}

