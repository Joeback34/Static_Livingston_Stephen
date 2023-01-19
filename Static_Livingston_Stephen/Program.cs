using System;

namespace Static_Livingston_Stephen
{
    class Program // Class.
    {   /// <summary>
    /// Prints the value of each Integer and Floater to the console.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args) // Main method.
        {   //Integers.
            Console.WriteLine("Integer Methods"); // Prints a messege to the console.
            Console.WriteLine("15 + 88 is " + Calculate.Add(15, 88));
            Console.WriteLine("5 - 8 is " + Calculate.Sub(5, 8));
            Console.WriteLine("5 * 38 is " + Calculate.Mult(5, 38));
            Console.WriteLine("44 / 5 is " + Calculate.Div(44, 5));

            //Floats.
            Console.WriteLine("\nFLoat Methods"); // Makes a new line and prints to the console.
            Console.WriteLine("15.55 + 88.88 is " + Calculate.Add(15.55f, 88.88f));
            Console.WriteLine("5.4 - 8.8 is " + Calculate.Sub(5.4f, 8.8f));
            Console.WriteLine("5.33 * 38.88 " + Calculate.Mult(5.33f, 38.88f));
            Console.WriteLine("44.5 / 5.3 is " + Calculate.Div(44.5f, 5.3f));
        }
    }
}
