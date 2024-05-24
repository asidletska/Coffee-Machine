using System;

namespace Coffee_machine
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select a drink: \n 1.Espresso \n 2.Americano \n 3.Americano with milk \n 4.Latte \n 5.Cacao \n 6.Tea");
                string input = Console.ReadLine();
                int cost = 0;
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please, select a drink size: 1.Small  2.Average");
                        string chooseEspresso = Console.ReadLine();
                        switch (chooseEspresso)
                        {
                            case "1":
                                cost += 15;
                                break;
                            case "2":
                                cost += 20;
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please, select a drink size: 1.Small  2.Average");
                        string chooseAmericano = Console.ReadLine();
                        switch (chooseAmericano)
                        {
                            case "1":
                                cost += 20;
                                break;
                            case "2":
                                cost += 25;
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Please, select a drink size: 1.Average 2.Big");
                        string chooseAmericanoWithMilk = Console.ReadLine();
                        switch (chooseAmericanoWithMilk)
                        {
                            case "1":
                                cost += 30;
                                break;
                            case "2":
                                cost += 40;
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Please, select a drink size: 1.Average 2.Big");
                        string chooseLatte = Console.ReadLine();
                        switch (chooseLatte)
                        {
                            case "1":
                                cost += 40;
                                break;
                            case "2":
                                cost += 50;
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Please, select a drink size: 1.Average 2.Big");
                        string chooseCacao = Console.ReadLine();
                        switch (chooseCacao)
                        {
                            case "1":
                                cost += 30;
                                break;
                            case "2":
                                cost += 40;
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Please, select a drink size: 1.Average 2.Big");
                        string chooseTea = Console.ReadLine();
                        switch (chooseTea)
                        {
                            case "1":
                                cost += 15;
                                break;
                            case "2":
                                cost += 25;
                                break;
                        }
                        break;

                }
                bool availabilityOfIngridients;
                {
                    availabilityOfIngridients = true;
                    if (availabilityOfIngridients == true)
                    {
                        Console.WriteLine("The drink is being prepared");
                    }
                    else
                    {
                        availabilityOfIngridients = false;
                        Console.WriteLine("For technical reasons we cannot prepare your drink");
                    }
                }
                if (cost != 0)
                {
                    Console.WriteLine($"Please insert {cost} cents.");
                }

                Console.WriteLine("Thanks for buying");
                Console.WriteLine("Enter any key to exit");
            }
        }
        
    }
}
