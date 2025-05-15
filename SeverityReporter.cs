using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtbashGame
{
    internal class SeverityReporter
    {
        public void Severity(string text, int score)
        {
            if (score <= 5)
            {
                text += "\n***WARNING***";
            }
            else if (score <= 10)
            {
                text += "\n***DANGER!***";
            }
            else if (score <= 15)
            {
                text += "\n***ULTRA ALERT!***";
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            Console.WriteLine(text + " " + Convert.ToString(score) + " points");
        }
    }
}
