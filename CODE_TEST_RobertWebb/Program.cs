using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_TEST_RobertWebb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new StringMatches();
            var inputText =
                "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea"; // input text


            var output = test.SubtextMatches(inputText, "ll");
            foreach (var o in output)
            {
                Console.WriteLine(o);
            }
        }
    }

}
