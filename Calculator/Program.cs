using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator. You can choose to either multiply or square.");
            var userChoice = Console.ReadLine();

            Console.WriteLine("Type numbers as 1,2,3, etc and press enter.");
            var userNumbers = Console.ReadLine();

            switch (userChoice.ToLower())
            {
                case "multiply":
                    var mult = userNumbers.Split(',');
                    Console.WriteLine(int.Parse(mult[0]) * int.Parse(mult[1]) * int.Parse(mult[2]));
                    break;
                case "square":
                    var square = userNumbers.Split(',');
                    Console.WriteLine(int.Parse(square[0]) * int.Parse(square[0]) + "," + int.Parse(square[1]) * int.Parse(square[1]) + "," + int.Parse(square[2]) * int.Parse(square[2]));
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please enter 'multiply' or 'square'. Then, enter numbers as instructed." +
                        "");
                    break;
            }
        }
    }
}
