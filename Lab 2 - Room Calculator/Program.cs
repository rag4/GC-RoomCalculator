using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.WriteLine("Grand Circus -- Lab 2 -- Ramon Guarnes's Room Calculator: ");

            Console.WriteLine();

            char checkFlag = 'y';   //FLAG FOR LOOP

            do
            {
                float length, width, heigth, area, perimeter, volume;

                //USER INPUTS LENGTH
                Console.WriteLine("\nEnter Length: ");
                string input = Console.ReadLine();
                length = float.Parse(input);

                //USER INPUTS WIDTH
                Console.WriteLine("\nEnter Width: ");
                input = Console.ReadLine();
                width = float.Parse(input);

                //USER INPUTS HEIGTH
                Console.WriteLine("\nEnter Heigth: ");
                input = Console.ReadLine();
                heigth = float.Parse(input);

                Console.WriteLine();

                //PROGRAM OUTPUTS AREA (l*w)
                area = length * width;
                Console.WriteLine("Area:" + area);

                //PROGRAM OUTPUTS PERIMETER (2l + 2w)
                perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Perimeter:" + perimeter);

                //PROGRAM OUTPUTS VOLUME (a * h)
                volume = area * heigth;
                Console.WriteLine("Volume:" + volume);

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
