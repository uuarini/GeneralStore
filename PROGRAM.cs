using System;

namespace LyonsProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store ggstore = new Store();

            decimal funds;

            var String1 = "Welcome to the General Goods Store.\n _____________________________ \n| _______   _______   _______ |\n" +
                "| |         |         |       |\n| |   ___   |   ___   |______ |\n| |     |   |     |         | |\n| " +
                "|_____|   |_____|   ______| |\n|_____________________________|\n\nWhat is your current budget?\n\n";

            foreach (var character in String1)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(15);
            }
            
            bool flag = decimal.TryParse(Console.ReadLine(), out funds);

            while (!flag || funds < 0)
            {
                var String2 = "That is nonsensical, what is your current budget?\n";
                foreach (var character in String2)
                {
                    Console.Write(character);
                    System.Threading.Thread.Sleep(30);
                }
                flag = decimal.TryParse(Console.ReadLine(), out funds);
            }

            /*Console.WriteLine($"Great! Your budget is {budget:C}.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Our current stock is:" + ggstore.ToString());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What would you like to buy?");*/

            var String3 = $"\nGreat! Your budget is {funds:C}.\n";
            var String12 ="What would you like to buy?\n";

            foreach (var character in String3)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine(ggstore.ToString());
            foreach(var character in String12)
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine();
            string itemName = (Console.ReadLine());
            itemName = itemName.ToLower();


            ggstore.Purchase(itemName, funds);
        }
    }
}
