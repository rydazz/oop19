using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolUppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = ReadInt("Type a number: ");
            //int y = ReadInt("Type another number: ");
            //Console.WriteLine($"{x} + {y} = {x + y}");

            //GetYear();


            //Console.WriteLine(IsPalindrome("Hej, jEh"));
            //Console.WriteLine(IsPalindrome(" heje eeeje jhe"));

            //FizzBuzz();

            //Game();
            //ChristmasTree();
           
            Console.ReadKey();
        }
        //public  static int ReadInt(string message) 
        //  {
        //      int result;
        //      while (true)
        //      {
        //          Console.WriteLine(message);
        //          var num = Console.ReadLine();

        //          if (int.TryParse(num, out result))
        //          {
        //              result = Convert.ToInt32(num);
        //              break;
        //          }
        //          else
        //          {
        //              Console.WriteLine("That's not a number, try again");
        //          }
        //      }
        //      return result;
        //  }

        //public static void LeapYear(int startyear, int endyear)
        //{
        //    for(int i = startyear; i <= endyear; i++)
        //    {
        //        if (DateTime.IsLeapYear(i))
        //        {
        //            Console.WriteLine(i + "*");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //public static void GetYear()
        //{
        //    int startyear = 0;
        //    int endyear = 0;
        //    bool inmat = true;


        //    while (inmat)
        //    {


        //    Console.WriteLine("Type in a year");
        //     startyear = int.Parse(Console.ReadLine());
        //    if (startyear < 0 || startyear > 9995)
        //    {
        //        Console.WriteLine("The startyear have to be betweeen 0 and 9999");
        //    }
        //    else
        //    {
        //        Console.WriteLine("OK");
        //            inmat = false;
        //    }

        //    }

        //    inmat = true;

        //    while (inmat)
        //    {


        //    Console.WriteLine("Type in another year");
        //     endyear = int.Parse(Console.ReadLine());
        //    if(endyear < startyear || endyear > 9999)
        //    {
        //        Console.WriteLine("The endyear have to be between {0} and 9999", startyear);
        //    }
        //    else
        //    {
        //        Console.WriteLine("OK");
        //            inmat = false;
        //    }

        //    }
        //    LeapYear(startyear, endyear);
        //}

        //public static bool IsPalindrome(string text)
        //{
        //    text = text.Replace(" ", "");
        //    text = text.Replace(",", "");
        //    text = text.Replace(":", "");

        //    int i = 0;
        //    int j = text.Length - 1;

        //    while (i < j)
        //    {

        //        if (!char.ToLower(text[i]).Equals(char.ToLower(text[j])))
        //            return false;

        //        i++;
        //        j--;
        //    }
        //    return true;
        //}

        //public static void FizzBuzz()
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //public static void Game()
        //{
        //    bool inmat = true;
        //    int guess = 0;
        //    var random = new Random();
        //    var number = random.Next(1, 101);

        //    int lowInt = 1;
        //    int highInt = 100;


        //    Console.WriteLine($"Random number between 1 and 100: ");
        //    Console.WriteLine("Start guessing");


        //    while (true)
        //    {
        //        var botguess = random.Next(lowInt, highInt);

        //        try
        //        {
        //            guess = int.Parse(Console.ReadLine());
        //            if (guess > number)
        //            {
        //                Console.WriteLine("Guess is to high");

        //            }
        //            else if (guess < number)
        //            {
        //                Console.WriteLine("Guess is to low");

        //            }
        //            else if (guess == number)
        //            {
        //                Console.WriteLine("You win the game!!!");
        //                inmat = false;
        //                break;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex);
        //            Console.WriteLine("Försök igen");
        //        }

        //        if (botguess > number)
        //        {
        //            Console.WriteLine("Computer guess number {0}", botguess);
        //            Console.WriteLine("Guess is to high");
        //            highInt = botguess;

        //        }
        //        else if (botguess < number)
        //        {
        //            Console.WriteLine("Computer guess number {0}", botguess);
        //            Console.WriteLine("Guess is to low");
        //            lowInt = botguess;
        //        }
        //        else if (botguess == number)
        //        {
        //            Console.WriteLine("Computer guess number {0}", botguess);
        //            Console.WriteLine("Computer win the game !!!");

        //        }
        //    }



        //}



        //public static void ChristmasTree()
        //{

        //    Console.Write("What size do you want? : ");
        //      int input = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < input; i++)
        //    {
        //        Console.Write(new string(' ', input - i));
        //        Console.Write(new string('*', i * 2 + 1));
        //        Console.WriteLine();
        //    }
        //    Console.Write(new string(' ', input));
        //    Console.Write("[]");
    
        //}
    }
}
