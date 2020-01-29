using System;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Agememnon", "Brad", "Charlie","Derek","Evan",
                "Fred","George","Hilda","Inga","Juliet" };
            string[] faveCandy = { "Airheads", "Butterscotch", "Chocolate",
            "DumDums","Eclairs","Ferrero Rocher Truffles","Godiva","Heath","iCandy by Apple","Juicy Fruit"};
            string[] previousTitle = { "Architect", "BA", "Courier",
                "Data Analyst","Evangelical Minister","Fiduciary","Golfer","Hotelier","Import/Export","Judge" };

            int input, index;
            bool parseBool = false, repeat = true;
            string inputString;



            do
            {
                Console.WriteLine("Would you like to see a list of students?: ");
                inputString = Console.ReadLine();
                while (inputString != "yes" && inputString != "no")
                {
                    Console.WriteLine("That was not a valid input. Please input" +
                        " “yes” or “no”: ");
                    inputString = Console.ReadLine();
                }
                if (inputString == "yes")
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {students[i]}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }

                /**/
                Console.Write($"Which student would you like to learn more about? " +
                        $"(enter a number 1-{students.Length}): ");

                parseBool = int.TryParse(Console.ReadLine(), out input);

                while (!parseBool || input < 0 || input > students.Length)
                {
                    Console.Write($"That was not a valid input. (enter a number" +
                        $" 1-{students.Length}): ");
                    parseBool = int.TryParse(Console.ReadLine(), out input);
                }
                index = input - 1;

                Console.Write($"What would you like to know about {students[index]} ? (enter " +
                    "“favorite candy” or “previous title”): ");
                inputString = Console.ReadLine();

                while (inputString != "favorite candy" && inputString != "previous title")
                {
                    Console.Write($"That was not a valid input. (enter " +
                    "“favorite candy” or “previous title”): ");
                    inputString = Console.ReadLine();
                }
                if (inputString == "favorite candy")
                {
                    Console.WriteLine($"{students[index]}'s {inputString} is {faveCandy[index]}.");
                }
                if (inputString == "previous title")
                {
                    Console.WriteLine($"{students[index]}'s {inputString} is {previousTitle[index]}.");
                }
                Console.WriteLine("Would you like to know about another student? " +
                    "(enter “yes” or “no”): ");
                inputString = Console.ReadLine();
                while (inputString != "yes" && inputString != "no")
                {
                    Console.WriteLine("That was not a valid input. Please input" +
                        " “yes” or “no”: ");
                    inputString = Console.ReadLine();
                }
                if (inputString == "no")
                {
                    repeat = false;
                }

            } while (repeat);
        }
    }
}
