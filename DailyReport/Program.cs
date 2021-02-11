using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n");
            Console.WriteLine("Student Daily Report \n");       

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
           
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();           
            Console.WriteLine("Your current course is: " + yourCourse);

            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(yourPage);
            Console.WriteLine("You are on page: " + yourPage);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            bool anyHelp = true;
            string helpStatus = Convert.ToString(anyHelp);
            Console.WriteLine(helpStatus);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("Positives if any: " + yourExperience);

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();
            Console.WriteLine("Feedback if any: " + yourFeedback);

            Console.WriteLine("How many hours did you study today?");
            string yourHours = Console.ReadLine();
            int studyHours = Convert.ToInt32(yourHours);

            Console.WriteLine("Thank you for your answers.  An instructor will respond shortly.  Have a great day! \n");
            Console.WriteLine("This is the end of the program.");

            Console.ReadLine();





        }
    }
}
