using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which month do you want to count days for? ");
            int month = Int32.Parse(Console.ReadLine());

            string daysInMonth;

            switch (month)
            {
                case 2:
                    daysInMonth = "28 or 29";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = "30";
                    break;
                default:
                    daysInMonth = "";
                    break;
            }

            if (daysInMonth != "")
            {
                Console.WriteLine($"The month {month} has {daysInMonth} days!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
