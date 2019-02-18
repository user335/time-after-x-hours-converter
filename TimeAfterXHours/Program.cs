using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAfterXHours
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The current time is " + DateTime.Now);
            Console.WriteLine("Now I will tell you what time it will be in X hours.");
            bool goodvaluereceived = false;
            while (!goodvaluereceived)
            {
                Console.Write("Give me an int value for X: ");
                var answer1 = Console.ReadLine();
                try
                {
                    int answer1int = Convert.ToInt32(answer1);
                    Console.WriteLine("Thanks");
                    DateTime date = DateTime.Now;
                    Console.WriteLine("In {0} hours the time will be {1}", answer1int, date.AddHours(answer1int));
                    goodvaluereceived = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("I didn't get a good value for X from you.");
                }
            }
            Console.ReadKey();
        }
    }
}
