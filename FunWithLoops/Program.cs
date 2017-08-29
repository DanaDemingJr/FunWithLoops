using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loops
            //string[] days = {"Monday", "Tuesday", "Wednesday"}
            //foreach (string item in days) ;
            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //    if(month == "Dec")
            //    {
            //        Console.WriteLine("That's the best month");
            //    }
            //    else
            //    {
            //        Console.WriteLine("that month is ok i guess....");
            //    }
            //}
            string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            foreach(string musician in musicians)
            {
                Console.WriteLine(musician);
            }

            //Create a program that asks the user for their favorite food and stores those values in an array
            //Loop through the array and print all of the foods 

            //create an array of lucky numbers using a foreach loop, print the following:
            //your lucky number is: 4
            //your lucky number is: 19
            //your lucky number is 7

            Console.WriteLine("What are you three favorite foods?");
            string foodOne = Console.ReadLine();
            string foodTwo = Console.ReadLine();
            string foodThree = Console.ReadLine();
            string[] favoriteFoods = new string[3];
            favoriteFoods[0] = foodOne;
            favoriteFoods[1] = foodTwo;
            favoriteFoods[2] = foodThree;
            foreach (string foods in favoriteFoods)
            {
                Console.WriteLine(foods);
            }

        }
    }
}
