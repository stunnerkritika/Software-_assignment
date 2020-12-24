using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Drawing;
using System.IO;

namespace Classassignment.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod_forFill_wrong_syntax()
        {

            //checking the validation by passing through the empty string to the command and running it 
            string given_input_code = "fill on and";

            Validation v = new Validation(given_input_code);
            string output_given_by_class = v.error_validation();
            string expected_output = "Please enter a valid code syntax";

            Assert.AreEqual(expected_output, output_given_by_class);

        }


        [TestMethod]

        public void TestMethod_for_Loop()
        {

            //checking the validation by passing through the empty string to the command and running it 
            string given_incorrect_input_code = "loop for x";

            Loop_Implementation v = new Loop_Implementation(given_incorrect_input_code);
            string output_given_by_class = v.error_handling_loop_implementation();


            string expected_output = "**Invalid variable for the loop**";

            Assert.AreEqual(expected_output, output_given_by_class);

        }
        [TestMethod]
        public void TestMethod_forValidation()
        {

            //checking the validation by passing through the empty string to the command and running it 
            string given_empty_input_code = "";
            
            Validation v = new Validation(given_empty_input_code);
            string output_given_by_class = v.error_validation();

            string expected_output = "Please enter a valid code syntax";

            Assert.AreEqual(expected_output, output_given_by_class);
        }


    }
}

