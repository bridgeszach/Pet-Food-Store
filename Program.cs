using System;
using System.Threading;

namespace catFoodStore
{
    class Program
    {
        //Ask Method for capturing the amount of cans being ordered
        static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();

        }

        //Wait Method after confirmation of purchase
        static void Wait()
        {   //  @ 2 seconds
            Thread.Sleep(2000);
        }


        //Price Method
        static float Price(int quantity)
        {
            float pricePerUnit;
            if (quantity >= 100)
            {
                pricePerUnit = 1.5f;
            }
            else if (quantity >= 50 && quantity <= 99)
            {
                pricePerUnit = 1.75f;
            }
            else
            {
                pricePerUnit = 2;
            }
            return quantity * pricePerUnit;
        }

        //Confirmation Method on can amount
        static string Confirmation(string option)
        {
            Console.Write(option);
            return Console.ReadLine();
        }

        //Main
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pet Food store!");

            string entry = Ask("How many cans are you ordering? ");

            int number = int.Parse(entry);  // String to int conversion parse

            float total = Price(number);   // Storing price total as variable

            Console.WriteLine($"You are ordering {number} cans. Is that correct?");
            string option = Confirmation("Y or N:  ");
            bool choice = true;
            while (choice == true)
            {
                if (option == "Y" || option == "y")
                {
                    Console.WriteLine("Great!");
                    Wait();
                    Console.WriteLine($"For {number} cans, your total is: ${total}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please retry your order.");
                    choice = false;
                    break;
                }
            }









        }
    }
}
