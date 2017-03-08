using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;

            while (true)
            {
                char operation = ' ';
                char[] validOps = { '+', '-', '*', '/' };

                bool operationConfirmed = false;
                while (!operationConfirmed)
                {
                    // prompt for operation
                    Console.WriteLine("What operation would you like to apply?");
                    string opInput = Console.ReadLine();
                    try
                    {
                        operation = opInput[0];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }


                    for (int i = 0; i < validOps.Length; ++i)
                    {
                        if (operation == validOps[i])
                        {
                            operationConfirmed = true;
                            break;
                        }
                    }

                    if (!operationConfirmed)
                    {
                        Console.WriteLine("Invalid operation.");
                    }
                }

                // prompt for number

                string numInput = Console.ReadLine();
                float userNumber = float.Parse(numInput);

                bool numberConfirmed = false;
                while (!numberConfirmed)
                {
                    try
                    {
                        userNumber = float.Parse(numInput);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number too big");
                    }
                }
                // apply operation
                switch (operation)
                {
                    case '+':
                        result += userNumber;
                        break;
                    case '-':
                        result -= userNumber;
                        break;
                    case '*':
                        result *= userNumber;
                        break;
                    case '/':
                        result /= userNumber;
                        break;
                    default:
                        //todo
                        break;
                }


                //display results
                Console.WriteLine(result);
            }


        }
    }
}
