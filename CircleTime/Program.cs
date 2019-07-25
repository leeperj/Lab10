using System;

namespace CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {


            string response = "";
            bool playAgain = true;
            bool validResponse = false;
            double input = 0;
            int counter = 0;
            while (playAgain)
            {
                counter++;
                validResponse = false;
                while (!validResponse)
                {
                    Console.Clear();
                    response = GetUserInput("Please enter the radius of a circle.");
                    validResponse = Validator.Double(response);
                   
                }
                   Circle circle = new Circle();
                input = double.Parse(response);
                circle.Radius = input;

                    Console.WriteLine($"A circle with the radius of {input} has the" +
                        $" circumference of {circle.CalculateFormattedCircumference()} and the area of {circle.CalculateFormattedArea()}.");





                    string quitChoice;
                    Console.WriteLine("Press (Q)uit to exit, or any key to go again");

                    quitChoice = Console.ReadLine().Trim();

                    if (quitChoice.ToLower() == "q" || quitChoice.ToLower() == "quit")
                    {
                        playAgain = false;
                    Console.WriteLine($"You've checked a total of {counter} circles. Have a nice day!");
                    }
            }
            
            
                
            
        }
            public static string GetUserInput(string prompt)
            {
                Console.WriteLine(prompt);
                return Console.ReadLine();
            }
    }
}
