using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        public string name;
        public int guess;
    }

    struct Transaction
    {
        public string itemName;
        public int itemPrice;
        public DateTime transactionDate;
    }

    class Program
    {
        static void PrintIntArray(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; ++i)
            {
                Console.Write(numArray[i]);
                Console.Write(" ");
            }
        }

        static void ReverseString(string given)
        {
            for (int i = given.Length - 1; i >= 0; i--)
            {
                Console.Write(given[i]);
            }
        }

        static bool isPalindrome(string given)
        {
            char[] reverse = given.ToCharArray();
            Array.Reverse(reverse);

            string rev = new string(reverse);

            given = given.ToLower();
            rev = rev.ToLower();

            return given == rev;
        }

        static Player[] GetWinner(Player[] players, int correctValue)
        {
            Player[] winners = new Player[players.Length];
            int count = 0;
            int lowest = Math.Abs(players[0].guess - correctValue);
            for (int i = 0; i < players.Length; i++)
            {
                if (Math.Abs(players[i].guess - correctValue) < lowest)
                {
                    lowest = Math.Abs(players[i].guess - correctValue);
                }
            }
            for (int i = 0; i < players.Length; i++)
            {
                if (Math.Abs(players[i].guess - correctValue) == lowest)
                    winners[count++] = players[i];
            }

            Console.WriteLine("The correct value was " + correctValue);
            if (winners.Length > 0)
            {
                for (int i = 0; i < count; i++)
                    Console.WriteLine(winners[i].name + " won with a guess of " + winners[i].guess);
            }

            else
                Console.WriteLine("There were no players.");

            return winners;
        }


        static void printTransaction(Transaction t)
        {
            Console.WriteLine(t.itemName + ": " + t.itemPrice / 100 + ", " + t.transactionDate);
        }
        static void ProcessTransaction(ref Transaction pending)
        {
            printTransaction(pending);
            pending.transactionDate = DateTime.Now;
            printTransaction(pending);
        }

        static void Main(string[] args)
        {
            int[] goober = { 6, 413, 234324, 69, 42, 000 };
            string r = "never gonna give you up never gonna let you down never gonna run around and desert you";
            string n = "Racecar";
            string m = "bottle";
            string a = "a";


            PrintIntArray(goober);

            ReverseString(r);

            isPalindrome(n);
            isPalindrome(m);
            isPalindrome(a);


            //I'm not using 3 lines for this
            Player p1 = new Player(); p1.name = "John"; p1.guess = 413;
            Player p2 = new Player(); p2.name = "Jane"; p2.guess = 314;
            Player p3 = new Player(); p3.name = "Henry"; p3.guess = 666;
            Player p4 = new Player(); p4.name = "Sarah"; p4.guess = 42;
            Player p5 = new Player(); p5.name = "DEREK"; p5.guess = 314;
            Player p6 = new Player(); p6.name = "terry"; p6.guess = 314;

            Player[] players = { p1, p2, p3, p4, p5, p6 };
            GetWinner(players, 300);

            Transaction t1 = new Transaction(); t1.itemName = "Sticky Hopper"; t1.itemPrice = 199; t1.transactionDate = DateTime.MinValue;
            Transaction t2 = new Transaction(); t2.itemName = "Loot Container"; t2.itemPrice = 199; t2.transactionDate = DateTime.MinValue;

            ProcessTransaction(ref t1);
            ProcessTransaction(ref t2);

            Console.ReadLine();

        }


    }
}
