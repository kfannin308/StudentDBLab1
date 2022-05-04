using System;

namespace StudentDBLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            bool validate = true;
            int studentNum;
            string ans;
            bool isValidInt;

            string[] studentNames = { "Jim Smith", "Mary Jones", "John Jackson", "Sarah James" };
            string[] homeTowns = { "Miami, FL", "Pittsburgh, PA", "Columbus, OH", "Detroit, MI" };
            string[] favFood = { "Pizza", "Salad", "Hamburgers", "Tacos" };


            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]}");
            }

            do
            {
                Console.WriteLine("Which student would you like to learn more about? Enter a number from 1 to 4:");

                ans = Console.ReadLine();
                isValidInt = int.TryParse(ans, out studentNum);

                do
                {
                    if (isValidInt == false)
                    {
                        Console.WriteLine("You didn't enter an integer. Please enter a number from 1 to {studentNames.Length}:");
                        validate = true;
                        ans = Console.ReadLine();
                        isValidInt = int.TryParse(ans, out studentNum);
                    }
                    else if (studentNum < 1)
                    {
                        Console.WriteLine("You entered a number less than 1. Please enter a number from 1 to {studentNames.Length}:");
                        validate = true;
                        ans = Console.ReadLine();
                        isValidInt = int.TryParse(ans, out studentNum);
                    }
                    else if (studentNum > studentNames.Length)
                    {
                        Console.WriteLine($"You entered a number higher than {studentNames.Length}. Please enter a number from 1 to {studentNames.Length}");
                        validate = true;
                        ans = Console.ReadLine();
                        isValidInt = int.TryParse(ans, out studentNum);
                    }
                    else validate = false;


                } while (validate == true);


            
                Console.WriteLine($"Student {studentNum} is {studentNames[studentNum - 1]}.");
                Console.WriteLine("What would you like to know?  Enter \"hometown\" or \"favorite food\":");
                ans = Console.ReadLine().ToLower();
                
                validate = true;
                do
                {
                    if (ans == "hometown")
                    {
                        Console.WriteLine($"{studentNames[studentNum - 1]}'s hometown is {homeTowns[studentNum - 1]}");
                        validate = false;
                    }
                    else if (ans == "favorite food")
                    {
                        Console.WriteLine($"{studentNames[studentNum - 1]}'s favorite food is {favFood[studentNum - 1]}");
                        validate=false;
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("You entered an invalid choice. Please enter \"hometown\" or \"favorite food\":");
                            ans = Console.ReadLine();
                        } while (ans != "hometown" && ans != "favorite food");
                    }
                }while (validate == true);
                Console.WriteLine("Do you want to continue: (y/n)");
                string ans2 = Console.ReadLine();
                if (ans2 != "y") { cont = false; }

                 
            } while (cont == true);
        }
    }
}
