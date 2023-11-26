using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment6part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Creating a one-dimensional array of string
            string[] startOfWord =
            {
                "Hello,my name is ",
                "I am fan of  ",
                "My favourite player is ",
            };
            string[] endOfWord =
            {
                ".",
                " Football Club.",
                ". He is a football legend."
            };
            List<string> responsesList = new List<string>();
            // Here the user inputs text
            Console.WriteLine("Please enter your name:");
            responsesList.Add(Console.ReadLine());
            Console.WriteLine("Please enter the football club you are a fan of:");
            responsesList.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of your favourite football player:");
            responsesList.Add(Console.ReadLine());
            // Creating a loop that takes each string in the array, with the user's responses
            for (int i = 0; i < startOfWord.Length; i++)
            {
                startOfWord[i] += responsesList[i];
                Console.WriteLine(startOfWord[i] + endOfWord[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings we used:");
            // Creating a loop that prints each string in the array on separates line
            for (int i = 0; i < startOfWord.Length; i++)
            {
                Console.WriteLine(startOfWord[i] + endOfWord[i]);

                // Part 2 
                // Creating an infinite loop (Uncomment line "i--" for infinite loop
                // Fix the infinite loop
                //i--;
            }
            Console.ReadLine();

            // Part 3
            Console.WriteLine("Is that gone be a goal!?!");
            StringBuilder goal = new StringBuilder();
            goal.Append("Goa");
            // Creating a loop using a "<" operator
            while (goal.Length < 10) 
            {
                goal.Append("l");
            }
            goal.Append("!");
            Console.ReadLine();
            Console.WriteLine(goal);
            Console.ReadLine();
            StringBuilder wow = new StringBuilder();
            wow.Append("Wo");
            // Creating a loop using a "<=" operator
            while (wow.Length <= 10)
            {
                wow.Append("w");
            }
            wow.Append("!");
            Console.WriteLine(wow);
            Console.ReadLine();

            // Part 4
            // Creating a list of strings where each item in the list is unique
            List<string> PremChamps = new List<string>() { "Arsenal FC", "Manchester United", "Blackburn Rovers", "Chelsea FC", "Manchester City", "Leicester City", "Liverpool FC" };
            Console.WriteLine("Premier League Era Champions:");
            // Asking the user to type a Premier League Champion
            Console.WriteLine("Enter a Premier League Era Champion:");
            int selection = 0;
            bool isTrue = false;
            int index = 0;
            // Creating a loop that iterates through the list of strings and displays the matching text
            while (!isTrue)
            {
                int j = 0;
                string champTeam = Console.ReadLine();
                foreach (string champ in PremChamps) 
                {
                    if (champTeam == champ) 
                    {
                        selection = j + 1;
                        index = j;
                    }
                    j++;
                }
                // Adding code to the above code that tells the user the selection is not available
                if (selection == 0)
                {
                    Console.WriteLine("That is not a Premier League Champion. Try again!");
                }
                // Adding code to the code above where the loop ends if a correct selection has been made
                else
                {
                    isTrue = true;
                }
            }
            Console.WriteLine("Loading...Index is: " + index + ". So...");
            Console.WriteLine("Premier League Champions are " + selection);
            Console.ReadLine();

            // Part 5
            // Creating a list of strings with two identical strings
            List<string> order = new List<string>() { "Order", "Continue Shopping", "Cancel", "Continue Shopping", "Continue Shopping", "Order", "Cancel" };
            Console.WriteLine("Welcome to Designerz! \nHere are the items in your basket. \nIf you want to proceed with your order " + "\"Order\".\nIf you want to continue adding items to your order \"Continue Shopping\".\nOtherwise you can cancel your order \"Cancel\".");
            // Here we asking the user to select text to search from the list
            Console.WriteLine("Enter your selection:");
            string select = Console.ReadLine();
            while (!(select == "Order" || select == "Continue Shopping" || select == "Cancel"))
            {
                // This code tells the user they have input text that is not in the list
                Console.WriteLine("Please enter one of the 3 choices:");
                select = Console.ReadLine();
            }
            Console.WriteLine("The items that match your selection is numbered:");
            // Here we create a loop that iterates through the loop and then displays the indices of the array that contains your selections
            for (int i3 = 0; i3 < order.Count; i3++)
            {
                if (select == order[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            // Part 6
            // Creating a list of strings that has at least two identical strings
            List<string> countries = new List<string>() { "Romania", "Canada", "Poland", "Poland", "Romania", "Norway", "South Korea", "Japan" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Country to visit:");
            // Creating a foreach loop that checks through the list and display a message showing the string and whether it has appeared in the list
            foreach (string country in countries) 
            {
                Console.WriteLine(country);
                if (repeatCheck.Contains(country))
                {
                    Console.WriteLine("This country has been repeated. \nUse last country initial when refering to this country.");
                }
                else
                {
                    Console.WriteLine("This country has not been repeated.");
                }
                repeatCheck.Add(country);
            }
            Console.ReadLine();
        }
    }
}
