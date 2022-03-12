using System;

namespace Deliverable2
{
    class Program
    {
        private static int waterCount = 0;
        private static int coffeeCount = 0;
        private static double buffetCost = 9.99;
        private static double coffeeCost = 2.00;
        static bool continueLoop = true;

        static void Main(string[] args)

        {
           
            //asking user for party sizw

            Console.WriteLine("Greetings Earthling. Welcome to The Martian Cantina. Humans receive special discounts. All you can eat for $9.99! We only charge extra for coffee. How many humans are in your group?");
            Console.WriteLine("Please, parties of 6 or fewer.");
            
            int partySize = Int32.Parse(Console.ReadLine());
            

            do
            {
                //conditional to end program 

                if (partySize > 6 || partySize <= 0)
                {
                    continueLoop = false;
                    break;

                } else
                {
                    Console.WriteLine($"We can accomodate a human party of {partySize}. Please follow me to your table.");
                    Console.WriteLine();
                    Console.WriteLine("Let's get everyone started with a beverage. I will then take your Earth dollars before allowing you to dine.");
                    Console.WriteLine();
                }

                // for loop to take drink order.

                for (int i = 1; i <= partySize; i++)
                {
                    Console.WriteLine($"Okay, human test subject number {i}. What is your drink order? You may choose coffee or water.");
                    Console.WriteLine();
                    string drinkOrder = Console.ReadLine();

                    if (drinkOrder != "water" && drinkOrder != "coffee")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Human test subject number {i} lacks short term memory. No drink then.");
                        Console.WriteLine();
                    }
                    else if (drinkOrder == "water")
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{drinkOrder} for human test subject number {i}.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Yes, we have heard humans love {drinkOrder}. Very interesting.");
                        Console.WriteLine();
                    }
                    // counting beverages

                    if (drinkOrder == "water")
                    {
                        waterCount++;
                    }
                    if (drinkOrder == "coffee")
                    {
                        coffeeCount++;
                    }
                    if (i >= partySize)
                    {
                        double totalCost = buffetCost * partySize + coffeeCount * coffeeCost;
                        Console.WriteLine();
                        Console.WriteLine($"Okay, so that's {waterCount} waters and {coffeeCount} coffees.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"Your total is ${totalCost}. Enjoy your meal.");
                        Console.WriteLine();
                        continueLoop = false;
                    } 
                } 

            } while (continueLoop);
            if (partySize > 6 || partySize <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("We cannot accomodate your party size. Have a nice day.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Farewell, human.");
            }
        } 
    }
}