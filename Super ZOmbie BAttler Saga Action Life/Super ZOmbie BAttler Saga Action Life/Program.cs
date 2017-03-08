using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_ZOmbie_BAttler_Saga_Action_Life
{
    class Program
    {
        static int playerLife = 100;
        static int zombieLife = 100;

        static int playerTurn(string input)
        {                        
            input = input.ToLower();            

            if (input == "attack")
            {
                return 1;
            }
            else if (input == "defend")
            {
                return 0;
            }
            else if (input == "counter")
            {
                return -1;
            }
            return 0;
        }

        static int zombieTurn()
        {
            Random ran = new Random();
            int choice = ran.Next(-1, 1);

            switch (choice)
            {
                case -1:

                    break;
                case 1:

                    break;

                case 0:
                default:

                    break;
            }

            return choice;
        }

        static void doBattle(int p, int z)
        {
            Random ran = new Random();



        }

        static void Main(string[] args)
        {
            int userNum = 0;
            int zombieNum = 0;



            Console.WriteLine("You have encountered a zombie! What do you do?");

            while (true)
            {
                Console.WriteLine("// Attack | Defend | Counter \\");

                try
                {
                    string userInput = Console.ReadLine();
                    playerTurn(userInput);
                    zombieNum = zombieTurn();                  
                    
                }

                catch
                {
                    Console.WriteLine("INVALID");
                }
                
            }



            


        }
    }
}
