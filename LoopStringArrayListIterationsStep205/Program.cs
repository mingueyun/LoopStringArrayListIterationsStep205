using System;
using System.Collections.Generic;
using System.Linq;

namespace LoopStringArrayListIterationsStep205
{
    class Program
    {
        static void Main()
        {
            //1.A one - dimensional array of strings.
            //2.Ask the user to input some text.
            //3.A loop that iterates through each string in the array and adds the user's text input to the end of each string. 
            //This step will not output anything to the console, but will update each array element by appending the user's text.
            //4.Then create a loop that prints off each string in the array on a separate line.


            string[] Months = { "January", "Feb", "March" };
            Console.WriteLine("what is the last food you ate? \n");
            string food = Console.ReadLine();
            
            for (int k = 0; k < Months.Count(); k++)
            {
                Console.WriteLine(Months[k] + food);

            }
            Console.ReadLine();


            ////////////////////////////////////////////////// Part Two///////////////////////
            //Infinite Loop

            //List<int> myaAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            //for (int a = 0; a < myaAges.Count; a--)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();

            // fix for infinite loop
            //List<int> myaAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            //for (int a = 0; a < myaAges.Count; a++)
            //{
            //    Console.WriteLine(myaAges[a]);
            //}
            //Console.ReadLine();


            ////////////////////////////////////////////////// Part Three///////////////////////



            //List<int> myAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            //for (int a = 0; a < myAges.Count; a++)
            //{
            //    if (myAges[a] < 50)
            //        Console.WriteLine("The ages list are " + myAges[a]);
            //}
            //Console.ReadLine();


            //List<int> myAges = new List<int> { 12, 7, 55, 33, 70, 50 };
            //for (int a = 0; a < myAges.Count; a++)
            //{
            //    if (myAges[a] <= 50)
            //        Console.WriteLine("The ages list are " + myAges[a]);
            //}
            //Console.ReadLine();





            ////////////////////////////////////////////////// Part Four///////////////////////


            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();
            //Console.WriteLine("Index of  : {0}", carColors.IndexOf(myColors));
            //Console.ReadLine();


            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //int myColors = Convert.ToInt32(Console.ReadLine());
            //if (myColors > -1 && myColors < 5)
            //{
            //    Console.WriteLine("Index of " + carColors[myColors]);
            //}
            //else
            //{
            //    Console.WriteLine(" you entered something wrong");
            //}
            //Console.ReadLine();


            //List<string> carColors = new List<string>() { "red", "yellow" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow");
            //string myColors = Console.ReadLine();
            //bool imGuessing = false;

            //do
            //{
            //    switch (myColors)
            //    {
            //        case "red":
            //            Console.WriteLine("Index value is {0}", "1");
            //            imGuessing = true;

            //            break;
            //        case "yellow":
            //            Console.WriteLine("Index value is {0}", "2");
            //            imGuessing = true;

            //            break;
            //        default:
            //            Console.WriteLine("try again");
            //            Console.WriteLine("what is your favorit car color? choose from below \nred, yellow");
            //            myColors = Console.ReadLine();
            //            break;
            //    }
            //}
            //while ( !imGuessing);
            //Console.ReadLine();

            ////////////////////////////////////////////////// Part five   ///////////////////////

            //string[] colorAr = { "red", "yellow", "blue", "green", "pink", "red" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();

            //int index = -1;
            //do
            //{
            //    index = Array.IndexOf(colorAr, myColors, index + 1);
            //    System.Console.WriteLine("The matching string are in index: " + index);
            //} while (0 == index);

            //Console.ReadLine();



            //string[] colorAr = { "red", "yellow", "blue", "green", "pink", "red" };
            //Console.WriteLine("what is your favorit car color? choose from below \nred, yellow, blue, green, pink");
            //string myColors = Console.ReadLine();

            //int index = -1;
            //do
            //{
            //    if (colorAr.Any(x => x == myColors))
            //    {
            //        index = Array.IndexOf(colorAr, myColors, index + 1);
            //        System.Console.WriteLine("The matching string are in index: " + index);
            //    }
            //    else
            //    {
            //        Console.WriteLine(" you entered something wrong");
            //    }
            //} while (0 == index);

            //Console.ReadLine();
            //            A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.

            //2.Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.

            //3.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.







            ////////////////////////////////////////////////// Part six   ///////////////////////
            //            1.Create a list of strings that has at least two identical strings in the list.

            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.



            //List<string> carColors = new List<string>() { "red", "yellow", "blue", "green", "pink", "blue" };
            //List<string> sameColors = new List<string>();

            //foreach (string color in carColors)
            //{
            //    if (!sameColors.Contains(color))
            //    {
            //        sameColors.Add(color);
            //        Console.WriteLine("colors in the list:  " + color);  
            //    }
            //    else
            //    {
            //        Console.WriteLine("There are duplicates colors and  they are::  " + color);    
            //    }
            //}

            //Console.ReadLine();

        }

    }

    
}
