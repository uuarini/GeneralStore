using System;
namespace LyonsProject2
{
    public class Store
    {
        private decimal earnings;

        string[] product = { "water", "candy", "pencil", "book", "tv" };

        decimal[] price = { 1.00m, .25m, .10m, 9.99m, 299.97m };

        int[] stock = new int[5];

        public Store()
        {
            Stock();
        }

        Random grandom = new Random();

        public void Stock()
        {
            stock[0] = grandom.Next(0, 10);
            stock[1] = grandom.Next(0, 10);
            stock[2] = grandom.Next(0, 10);
            stock[3] = grandom.Next(0, 10);
            stock[4] = grandom.Next(0, 10);
        }

        public override string ToString()
        {
            return "\nOur current stock is:\n ______________________ \n| PRODUCT | PRICES | # |\n|______________________|\n| " + product[0] + "   |$   " + price[0] + "| " + stock[0]+
                " |\n|_________|________|___|\n| " + product[1] + "   |$   " + price[1] + "| " + stock[1] +
                " |\n|_________|________|___|\n| " + product[2] + "  |$   " + price[2] + "| " + stock[2] +
                " |\n|_________|________|___|\n| " + product[3] + "    |$   " + price[3] + "| " + stock[3] +
                " |\n|_________|________|___|\n| " + product[4] + "      |$ " + price[4] + "| " + stock[4] + " | \n|______________________|\n";
        }

                public void Purchase(string itemName, decimal funds)
                {
                    {
                while (itemName != "y" && itemName != "yes")
                {
                    var String5 = "\nI'm sorry, but that was an invalid selection.\n" +
                            "\nWill that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";

                    if (itemName == product[0] && stock[0] > 0 && funds > 1)
                    {
                        stock[0]--;
                        funds--;
                        earnings++;
                        var String4 = $"\nThanks for the purchase. Your budget is now {funds:C}\n";
                        var String11 = "Will that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";
                        foreach (var character in String4)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString());
                        foreach (var character in String11)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();

                    }
                    else if (itemName == product[1] && stock[1] > 0 && funds > .25m)
                    {
                        stock[1]--;
                        funds -= .25m;
                        earnings += .25m;
                        var String6 = $"\nThanks for the purchase. Your budget is now {funds:C}\n";
                        var String13 = "Will that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";
                        foreach (var character in String6)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString());
                        foreach (var character in String13)

                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();

                    }
                    else if (itemName == product[2] && stock[2] > 0 && funds > .1m)
                    {
                        stock[2]--;
                        funds -= .1m;
                        earnings += .1m;
                        var String8 = $"\nThanks for the purchase. Your budget is now {funds:C}\n";
                        var String14 = "Will that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";
                        foreach (var character in String8)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString());
                        foreach (var character in String14)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();

                    }
                    else if (itemName == product[3] && stock[3] > 0 && funds > 9.99m)
                    {
                        stock[3]--;
                        funds -= 9.99m;
                        earnings += 9.99m;
                        var String9 = $"\nThanks for the purchase. Your budget is now {funds:C}\n";
                        var String15 = "Will that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";
                        foreach (var character in String9)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString());
                        foreach (var character in String15)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();

                    }
                    else if (itemName == product[4] && stock[4] > 0 && funds > 299.97m)
                    {
                        stock[4]--;
                        funds -= 299.97m;
                        earnings += 299.97m;
                        var String10 = $"\nThanks for the purchase. Your budget is now {funds:C}\n";
                        var String16 = "Will that be all? Enter another item or \"yes\" or \"y\" to quit\n\n";
                        foreach (var character in String10)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString());
                        foreach (var character in String16)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();

                    }
                    else if (itemName == "rob")
                    {
                        itemName = "y";
                        stock[0] = 0;
                        stock[1] = 0;
                        stock[2] = 0;
                        stock[3] = 0;
                        stock[4] = 0;
                        var String20 = "\nOh my God! Here, take whatever you want, please don't hurt me...\n";
                        foreach (var character in String20)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        Console.WriteLine(ToString() + "\n ---------------------\n| SORRY, WE'RE CLOSED |\n ---------------------\n");
                    }
                    else
                    {
                        foreach (var character in String5)
                        {
                            Console.Write(character);
                            System.Threading.Thread.Sleep(30);
                        }
                        itemName = Console.ReadLine();
                        itemName = itemName.ToLower();


                    }
                }
                            Console.WriteLine($"Thanks for your business! Please come again! Store earnings: {earnings:C}");

            }
        }

    }
}
