using NewBankingingApp;
using System;
using System.Threading.Channels;

namespace NewBankingApp
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            var BankAccount = new BankAccount("nana Tazoh", 500);
            Console.WriteLine($"Account {BankAccount.Number} was created for {BankAccount.Owner} with the balance of {BankAccount.Balance}.");

            BankAccount.MakeDeposite(200, DateTime.Now, "Susan Hetchckock");
            Console.WriteLine(BankAccount.Balance);

            try
            {
                var invalidAccount = new BankAccount("stealing", -234);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negatige balance");
                Console.WriteLine(e.ToString());
            }
            BankAccount.MakeWithdral(100, DateTime.Now, "200", "nana Tazoh");

            /*
             EXPERIMENTAL CODE GETTING READY FOR AUTOMATION TESTING
             */
            //string[] accountNames;
            //accountNames = new string[] { "Foe", "Ames", "JBenny" };
            //Array.Sort(accountNames);
            //for (int i = 0; i < accountNames.Length; i++)
            //{
            //    Console.WriteLine(accountNames[i]);
            //}

            //int[] myNumbers = { 5, 1, 8, 9 };
            //Console.WriteLine(myNumbers.Sum());  // returns the largest value

            //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers[i, j]);
            //    }
            //}

            //TryingSomethingOut trying = new TryingSomethingOut();
            //TryingSomethingOut main = new newinherit();
            //TryingSomethingOut sec = new newone();

            //trying.MakeASound();
            //main.MakeASound();
            //sec.MakeASound();

            ////using System.IO;  // include the System.IO namespace

            //string writeText = "Hello World!";  // Create a text string
            //File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            //string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            //Console.WriteLine(readText);  // Output the content
        }
    }
}