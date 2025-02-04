// Module 3 Challenge
// Alessandro Cardenas-Engle
// 2/3/25

using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());

            //Add code here for your if-else statement.
            // if else statement for hunger level of a lion
            if (hungerLevel >= 8) {
                Console.WriteLine("Lion: Roar! I need a big meal!");
            }
            
            // if else statement for the hunger level of a monkey
            else if (hungerLevel >= 5) {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");

            }

            // Otherwise, the hunger level is a tortoise 
            else {
                Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
            }

            // Ternary operator to output animal sounds based on hunger level
            String animalSound = hungerLevel >= 8 ? "Listen to the Lion: Roar!" :
            "Listen to the Monkey: Ooh ooh!";
            Console.WriteLine(animalSound);

            // Asks the user to enter a day of the week from 1-7
            Console.Write("Enter a day of the week from 1 to 7 (Ex: Sunday is 1, Saturday is 7): ");
            int dayOfTheWeek = int.Parse(Console.ReadLine());
            
            // Switch method used to display a message for each day of the week
            switch (dayOfTheWeek) {

                case 7:
                    Console.WriteLine("You wish your weekend went as slow as it does here for sloth Saturday!");
                    break;
                case 6:
                    Console.WriteLine("Look up and experience what it feels like to fly high on falcon Friday!");
                    break;
                case 5:
                    Console.WriteLine("Don't be so hard on yourself and come by for turtle Thursday!");
                    break;
                case 4:
                    Console.WriteLine("Take a big splash at out new whale Wednesday show!");
                    break;
                case 3:
                    Console.WriteLine("See how loud you can ROAR! for Tiger Tuesday!");
                    break;
                case 2:
                    Console.WriteLine("Come by and go bananas at the monkey Monday show!");
                    break;
                case 1:
                    Console.WriteLine("Slither on over for serpent Sunday here at the Zoo!");  
                    break;  
            }
            
        }

    }
}