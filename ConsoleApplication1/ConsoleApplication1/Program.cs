using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Square(string number)
        {
            ulong sq = ulong.Parse(number);
            sq = sq * sq;
            Console.WriteLine(number + " it is " + sq);
        }

        static void Main(string[] args)
        {
            //Vector2 vec = new Vector2();
            //Vector2 vec2a = new Vector2(1.0f);
            //Vector2 vec2b = new Vector2(1.0f, 1.0f);

            //TrackData t1 = new TrackData("Never Gonna Give You Up", 211, "Rick Astley", "Whenever You Need Somebody");
            ////            Console.WriteLine(t1.ToString());

            //Name john = new Name();
            //john.firstName = "John";
            //john.middleName = "Earl";
            //john.lastName = "Madden";

            //Name ab = new Name();
            //ab.firstName = "Abraham";            
            //ab.lastName = "Lincoln";

            //Console.WriteLine(john.FullName);
            //Console.WriteLine(john.Initials);

            //Console.WriteLine(ab.FullName);
            //Console.WriteLine(ab.Initials);

            //Console.ReadLine();

            while (true)
            {
                Console.WriteLine("What number would you like to square?");
                string input = Console.ReadLine();
                try
                {
                    Square(input);
                    Console.ReadLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sorry, that doesn't seem to be a number.");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Sorry, that number is too big.");
                }
            }

        }
    }
}
