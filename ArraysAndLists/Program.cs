using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructions
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            #endregion

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
            StringBuilder output = new StringBuilder();

            output.AppendLine("The List of Even numbers are:");

            foreach (var evennumber in evens)
            {
                output.AppendLine(evennumber.ToString());
            }

            output.AppendLine(Environment.NewLine);
            output.AppendLine("The List of Odd numbers are:");

            foreach (var oddnumber in odds)
            {
                output = output.AppendLine(oddnumber.ToString());
            }
            Console.WriteLine(output.ToString());
        }
    }
}