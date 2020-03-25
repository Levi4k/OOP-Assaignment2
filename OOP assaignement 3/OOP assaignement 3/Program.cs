using System;

namespace OOP_assaignement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Answer;

            do
            {//basic menu
                Console.WriteLine("Would you like to compare the two files?");
                Answer = Console.ReadLine();
                Answer.ToLower();
                if (Answer == "yes")
                {
                    break;
                }
                else if (Answer == "no")
                {
                    Console.WriteLine("Please close the application");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Please only enter yes or no.");
                }

            } while (Answer != "yes" || Answer != "no");
            File_Loading.Loading_Files();//calls the next function
        }
    }
}
