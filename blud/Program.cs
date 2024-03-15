using System;
using System.Collections.Generic;

namespace FunwithQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> food = new Queue<string>();


            food.Enqueue("banana");
            food.Enqueue("apple");
            food.Enqueue("cereal");
            food.Enqueue("ramen");
            food.Enqueue("mac and cheese");


            // adding more members
            Console.WriteLine("How many food items you trynna add snipe? ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Food name: ");
                food.Enqueue(Console.ReadLine());
            }
            Console.WriteLine($"Here are your {food.Count()} items snipe");
            foreach (var f in food)
            {
                Console.WriteLine(f);
            }
            string firstFood = food.Peek();
            Console.WriteLine($"Would you like to remove {firstFood} from the top of the queue snipe? (yes or no)?");
            string answer = Console.ReadLine();
            while (answer=="yes")
            {
                food.Dequeue();
                firstFood= food.Peek();
                Console.WriteLine($"Would you like to remove {firstFood} from the top of the queue snipe?(yes or no)?");
                answer = Console.ReadLine();
            }

            if (food.Peek() == null)
                Console.WriteLine("queue is empty snipe");
            else
                Console.WriteLine($"You have {food.Count} left in the queue snipe");

        }
    }
}

