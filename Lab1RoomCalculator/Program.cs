using System;

namespace Lab1RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool measureAgain = true;
            string answer;

            while (measureAgain)
            {

                answer = "";

                Console.WriteLine("Hey there! Today we'll be helping you find out how much paint and carpeting you'll need for a specific room.");


                Console.WriteLine("Please enter the room's length in feet.");
                float length = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the room's width in feet.");
                float width = float.Parse(Console.ReadLine());

                float area = (length * width);
                float perimeter = 2 * (length + width);
                float paint = perimeter / 5;
                float carpet = area / 5;

                Console.WriteLine($"The area is {area}. The perimeter is {perimeter}. You'll need {paint} cans of paint, and {carpet} tiles of carpet. ");

                Console.WriteLine("Would you like to measure another room? Say 'yes'. If not, say 'no'.");

                answer = Console.ReadLine();

                if (answer == "yes") {

                    measureAgain = true;
                }

                else measureAgain = false;



                
            }
        }
    }
}
