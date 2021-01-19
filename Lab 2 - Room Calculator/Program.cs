using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //FLAG FOR LOOP
            char checkFlag = 'y';

            do
            {
                //INTRO
                Console.WriteLine("Grand Circus -- Lab 2 -- Ramon Guarnes's Room Calculator: ");

                Console.WriteLine();

                //USER INPUTS LENGTH
                Console.WriteLine("\nEnter Length: ");
                string input = Console.ReadLine();
                float length = float.Parse(input);

                //USER INPUTS WIDTH
                Console.WriteLine("\nEnter Width: ");
                input = Console.ReadLine();
                float width = float.Parse(input);

                Console.WriteLine();

                //PROGRAM OUTPUTS AREA (l*w)
                float area = length * width;
                Console.WriteLine("Area:" + area);

                //PROGRAM OUTPUTS PERIMETER (2l + 2w)
                float perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Perimeter:" + perimeter);

                Console.WriteLine();

                //USER INPUTS IF WANT TO CONTINUE
                Console.WriteLine("Continue? (y/n)");
                checkFlag = Console.ReadLine()[0];

            } while (checkFlag == 'y'); // y = again , n = quit

            //ENDING MESSAGE
            Console.WriteLine();
            Console.WriteLine("You have quit the application. Thank you.");
        }
    }
}
