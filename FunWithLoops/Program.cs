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
            //string[] musicians = { "U2", "Maroon 5", "Ed Sheeran", "Nas", "Jarryd" };
            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}

            //Create a program that asks the user for their favorite food and stores those values in an array
            //Loop through the array and print all of the foods 

            //create an array of lucky numbers using a foreach loop, print the following:
            //your lucky number is: 4
            //your lucky number is: 19
            //your lucky number is: 7

            //Console.WriteLine("What are you three favorite foods?");
            //string foodOne = Console.ReadLine();
            //string foodTwo = Console.ReadLine();
            //string foodThree = Console.ReadLine();
            //string[] favoriteFoods = new string[3];
            //favoriteFoods[0] = foodOne;
            //favoriteFoods[1] = foodTwo;
            //favoriteFoods[2] = foodThree;
            //foreach (string foods in favoriteFoods)
            //{
            //    Console.WriteLine(foods);
            //}

            //int[] luckyNumbers = { 4, 19, 7 };
            //foreach(int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is: " +number);
            //}

            //string[] Names = { "Jordan", "Max", "Peter" };
            //for(int i = 0; i < Names.Length; i++)
            //{
            //    Names[i] = Names[i].ToLower();
            //    Console.WriteLine(Names[i]);
            //}

            //for (int counter = 1; counter <= 10; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //for(int counterAgain =50; counterAgain <= 100; counterAgain++)
            //{
            //    Console.WriteLine(counterAgain);
            //}

            //string words = "I like cake";
            //foreach(char letter in words)
            //{
            //    Console.WriteLine(letter);
            //}

            //string greetings = "My name is Dana";
            //string[] words = greetings.Split();
            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //    if(words[i] == "Dana")
            //    {
            //        words[i] = "Max";
            //    }
            //}
            //Console.WriteLine(words.[words.Length - 1]); 

            //create an array called days with the elements monday - sunday
            //use a forloop to print the elements to the console
            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //create an int array size 25 put the numbers 0 - 25 in the array and print those numbers to the console *newkeyword
            //int[] callNumber = new int[26];
            //for (int i = 0; i <= 25; i++)
            //{
            //    callNumber[i] = i;
            //    Console.WriteLine(callNumber[i]);
            //}

            //Start with the string "once upon a time" and create an array called storyWords using the split method.
            //reverse the order of the elements in the array and using a for loop, print each word

            //string words = "Once upon a time";
            //string[] storyWords = words.Split();  //splitting on the white space
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //while loops

            //Console.WriteLine("Do you want to play a game");
            //string playAgain = Console.ReadLine();
            //while(playAgain == "Yes")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("What is your favorite ROYGBIV color");
            //string userColor = Console.ReadLine();
            ////bool isROYGBIV = false;
            //while(userColor != "red")
            //{
            //    Console.WriteLine("Sorry that is not the correct color, please try again");
            //    userColor = Console.ReadLine();
            //}

            //do while loops
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Do you want to build a snowman?");
            //    Console.WriteLine("That was fun");
            //    Console.WriteLine("Do you want to build another snowman");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "yes");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //}


            //int x = 1;
            //while(x<=10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //int lives = 3;
            //int magicNumber = 24;
            //bool isPlaying = true;
            //while(lives > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess my lucky number");
            //    int userGuess = int.Parse(Console.ReadLine());
            //    if(magicNumber == userGuess)
            //    {
            //        Console.WriteLine("You guessed right!!");
            //        isPlaying = false;
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry Try Again");
            //        lives--;
            //        Console.WriteLine("You have " + lives + " left");
            //    }
            //}

            //print the numbers 1 - 100
            //if the number is a multiple of 3 print fizz, multiple of 5 print buzz, multiple of both fizzbuzz

            //create an int array wiht 10 elements, find the mean of these elements and output the result

            //int x = 1;
            //while (x <= 100)
            //{
            //    if(x % 15 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if(x % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if(x % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x++;
            //}

            //int[] averages = { 75, 80, 90, 95, 87, 88, 81, 90, 100, 98 };
            //int total = 0;
            //foreach (int number in averages)
            //{
            //    total += number;
            //}
            //int mean = total / averages.Length;
            //Console.WriteLine(mean);


            //NESTED LOOPS
            //for (int i = 1; i <= 2; i++)
            //{
            //    for(int j = 1; j <= 4; j++)
            //    {
            //        Console.Write(j); //columns
            //    }
            //    Console.WriteLine(); //two
            //}

            //print a triangle with nested loop
            //int n = 4;
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int column = 1; column <= row; column++)
            //    {
            //        Console.Write(column +" ");
            //    }
            //    Console.WriteLine();
            //}

            //multiplication tables


            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int column = 1; column <= 5; column++)
            //    {
            //        Console.Write("{0} X {1} ", row, column);
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine();

            //string[] favoriteMovies = { "Superbad", "Wolf of Wallstreet", "Entourage" };
            //string[] vowelArray = { "E" };
            //foreach(string movie in favoriteMovies)
            //{
            //    foreach (string vowel in favoriteMovies)
            //    {
            //        if (vowel.StartsWith("E"))
            //            Console.WriteLine(movie);
            //    }


            //}

            //ask the user for a number
            //see if the number is divisible by 3
            //if the number is not a multiple of 3, tell the user "you lost" and ask for a new number
            //until the user wins
            //once outside the loop print you win

            //Console.WriteLine("Please enter a winning number");
            //int userNumber = int.Parse(Console.ReadLine());
            //while(userNumber % 3 !=0)
            //{
            //    Console.WriteLine("You lose, try again");
            //    userNumber = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Winner, winner, chicken dinner");

            //ask the user for 2 numbers. n & m
            //see if m is larger than n, if not enter new numbers
            //between n & m find all numbers divisible by 3

            //Console.WriteLine("Please enter a number");
            //int userNumberN = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a second number");
            //int userNumberM = int.Parse(Console.ReadLine());
            //while(userNumberN >= userNumberM)
            //{
            //    Console.WriteLine("Please enter a new number");
            //    userNumberN = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter a second number that is larger than the first");
            //    userNumberM = int.Parse(Console.ReadLine());
            //}
            
            //for (int i = userNumberN; i < userNumberM; i++)
            //{
            //   if (i % 3 == 0)
            //        Console.WriteLine(i); 
            //}
                
            




                


            


             




        }
    }
}
