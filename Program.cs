using System;




namespace CS_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            //int = named i that is integer
            //float is floating number ??? I dont get this one
            //double with "more precision" ...decimals ok
            // bool = t/f
            // char = character
            // string = string of characters

            TestFunction();


            Console.WriteLine("Hello World!"); //return based on number below in function

            int i = 5;


            switch (i)
            {
                case 1:  
                Console.Write("first case!");
                    break;
                case 2:
                Console.Write("second case");
                    break;
                case 3:
                Console.WriteLine("third case!");
                    break;

            }






            bool b = SecondTestFunction(i);

            if (i < 10)
            {
                Console.WriteLine("TRUE...yea boiiiiiiiii");
            }
            else
            {
                Console.WriteLine("FALSE...sorry, but " + i + " is " + i);
            }

            Console.ReadKey(); //not sure what this does yet











            
        }

        static void TestFunction()
        {
            //returns nothing
        }
        static bool SecondTestFunction(int i)
        {
            return i < 12;
        }

    }
}





//important: love detector assignment #1 Monday
// public class LoveDetector
// {
//     public static bool lovefunc(int flower1, int flower2)
//     {
//         //Moment of truth...
//     }
// }


//important original boilerplate
// namespace dotnet_hello_world
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }


//NOTES:
//bool default is false
