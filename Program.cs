using System;

namespace homeWorkControlEntering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exitCommand = "exit";
            string inputUser = " ";

            while (inputUser != exitCommand)
            {
                Console.Write("Enter the correct command to exit the programm: ");
                inputUser = Console.ReadLine();

                if (inputUser == exitCommand)
                {
                    Console.WriteLine("Correct command, good bye!");
                }              
            }
        }
    }
}
