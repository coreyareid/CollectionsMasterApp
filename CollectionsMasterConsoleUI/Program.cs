using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            
            //TODO: Create an integer Array of size 50
            int[] myNumbersArray = new int[51];
            
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 5.
             static void PopulateMethod(int[] array)
            {
                Random r = new Random();
                
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(0, 5);
                }
            }
            PopulateMethod(myNumbersArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"The first number in the array is: {myNumbersArray[0]}");

            //TODO: Print the last number of the array            
            Console.WriteLine($"The last number in the array is: {myNumbersArray[50]}");
            Console.WriteLine("\nAll Numbers Original");

            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myNumbersArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            //  1) First way, using a custom method => Hint: Array._____();
            //  2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myNumbersArray);
            NumberPrinter(myNumbersArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

             static void OfThreeToZero(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        array[i] = 0;

                    }
                }
            }
             OfThreeToZero(myNumbersArray);
             NumberPrinter(myNumbersArray);
            Console.WriteLine("-------------------");
           
            //TODO: Sort the array in order now
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myNumbersArray);
            NumberPrinter(myNumbersArray);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
            
            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myNumbersList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("The capacity is: " + myNumbersList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            static void RandomNumsList(List<int> list)
            {
                Random rList = new Random();
                for (int i = 0; i < 50; i++)
                {
                    list.Add(rList.Next(0, 50));
                }
            }
            RandomNumsList(myNumbersList);

            //TODO: Print the new capacity
            Console.WriteLine("The new capacity is: " + myNumbersList.Capacity);
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            static void IsInList(List<int> list)
            {
                Console.WriteLine("Put in a number to see if it\'s in the list.");
                int theirNumber = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < list.Count; i++)
                {
                    if (theirNumber == list[i])
                    {
                        Console.WriteLine("That number IS in the list");
                        break;
                    }
                    /*else if (theirNumber != list[i])
                    {
                        Console.WriteLine("That number is Not in the list");
                        
                    }*/
                }
            }
            IsInList(myNumbersList);
            
            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers in list: ");
            NumberPrinter(myNumbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            static void EvensOnly(List<int> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list.RemoveAll(i => i % 2 != 0);
                }
            }

            EvensOnly(myNumbersList);
            NumberPrinter(myNumbersList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myNumbersList.Sort();
            NumberPrinter(myNumbersList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listToArray = myNumbersList.ToArray();

            //TODO: Clear the list
            myNumbersList.Clear();
            NumberPrinter(myNumbersList);
            Console.WriteLine("List has been cleared.");
            #endregion
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
