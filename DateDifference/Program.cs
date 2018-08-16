using System;
namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input
            Console.WriteLine("This program will count the difference between two dates." +
                "Please enter the first date:");

            //acquire user input as DateTime
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            //prompt user for input
            Console.WriteLine("Please enter the second date:");

            //acquire user input as DateTime
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            //declare TimeSpan variable dateDifference
            //this is so we can assign it a value in the below if/else-if statement
            //we can also avoid issues with scope later in the program by...
            //... declaring the variable outside of the if/else-if statement.
            TimeSpan dateDifference;

            //determine whether date1 or date2 is larger
            //this is so that we can find the difference between date1 and date2
            if (date1 > date2)
            {
                dateDifference = date1 - date2;
            }
            else if (date2 > date1)
            {
                dateDifference = date2 - date1;
            }

            //declare a variable and assign it the value of the days in dateDifference
            double dayDifference = dateDifference.TotalDays;

            //display dateDifference
            Console.WriteLine("There are " + dayDifference " days between these two dates.");

            //keep the program open
            Console.ReadLine();

        }
    }
}
