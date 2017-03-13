using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degelates_and_Enevts
{
    class Program
    {
        // PA
        public delegate void AnnounceHandler(string message);

        public static void TextOutput(string message)
        {
            Console.WriteLine(message);
        }

        public static void TextOutputUpper(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public static void TextOutputLower(string message)
        {
            Console.WriteLine(message.ToLower());
        }

        public static void TextOutputBreaks(string message)
        {
            //Console.WriteLine(message.ToLower().Replace(' ', '.'));
            message = message.ToLower();
            string[] breaks = message.Split(' ');
            for (int i = 0; i < breaks.Length; ++i)
            {
                Console.Write(breaks[i]);

                if (i != breaks.Length - 1)
                    Console.Write(".");
            }
        }

        // Delegate Calc
        public delegate void Operator(float lhs);

        static float result = 0;

        public static void Add(float rhs) { result += rhs; }
        public static void Sub(float rhs) { result -= rhs; }
        public static void Mul(float rhs) { result *= rhs; }
        public static void Div(float rhs) { result /= rhs; }

        static void Calculator()
        {
            result = 0;

            while (true)
            {
                Console.WriteLine("what do you wanna do?");

                yes = Console.ReadLine();

                try
                {
                    gimmeDelegates(oper, number);
                }

                catch
                {

                }
            }
        }

        static void Main(string[] args)
        {
            //AnnounceHandler announce;
            //string word;

            //announce = TextOutput;
            //announce += TextOutputUpper;
            //announce += TextOutputLower;
            //announce += TextOutputBreaks;
            //word = Console.ReadLine();
            //announce(word);
            //Console.ReadLine();

        }
    }
}
