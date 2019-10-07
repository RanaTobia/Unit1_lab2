using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {

        static void Main(string[] args)
        {
            string mood;
            int partyOf;
            string travalBy;

            // Greeting People and input the options 
            Console.WriteLine("Hi there!! What are you in the mood for? ");
            Console.WriteLine("Here are your options:");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");


            mood = Console.ReadLine();

            // input the number of people 

            Console.WriteLine("How many people are you bringing with you?");
            partyOf = Convert.ToInt32(Console.ReadLine());

            // Find the Way of Traval

            if (partyOf == 0)
            {
                travalBy = "sneakers";
            }
            else if (partyOf >= 1 && partyOf <= 4)
            {
                travalBy = "a sedan";
            }
            else if (partyOf >= 5 && partyOf <= 10)
            {
                travalBy = "a Volkswagen bus";
            }
            else if (partyOf >= 5 && partyOf <= 10)
            {
                travalBy = "a Volkswagen bus";
            }
            else if (partyOf >= 11)
            {
                travalBy = "an airplane";
            }
            else
                travalBy = " ";

            // Create the Logic
            switch (mood)
            {
                case ("Action"):

                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Stock Car Racing and travel in " + travalBy + "!");
                    break;
                case ("action"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Stock Car Racing and travel in " + travalBy + "!");
                    break;
                case ("Chill times"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Hiking and travel in " + travalBy + "!");
                    break;
                case ("chill times"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Hiking and travel in " + travalBy + "!");
                    break;
                case ("Danger"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Skydiving and travel in " + travalBy + "!");
                    break;
                case ("danger"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to Skydiving and travel in " + travalBy + "!");
                    break;
                case ("Good Food"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to To Taco Bell and travel in " + travalBy + "!");
                    break;
                case ("good food"):
                    Console.WriteLine("Okay if you’re in the mood for " + mood + " ,then you should go to To Taco Bell and travel in " + travalBy + "!");
                    break;
                default:
                    Console.WriteLine("Sorry the input was not understood. Try agin please");
                    return;

            }


            // Ending the program 

            Console.WriteLine("Goodbye");
        }
    }
}






