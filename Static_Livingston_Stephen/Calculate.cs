using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Livingston_Stephen
{
    class Calculate // static class called caculate.
    {
        public static float result = 0.0f;  // creates float called result.

        static Calculate()  // Constructor that initializes the result value to 0.0f
        {
            result = 0.0f;
        }
        // INTEGERS.
        public static int Add(int x, int y) // Methods adding 2 integers returning results.
        {
            return x + y;
        }

        public static int Sub(int x, int y) // Methods subtracting 2 integers returning results.
        {
            return x - y;
        }

        public static int Div(int x, int y) // Methods dividing 2 integers returning results.
        {
            return x / y;
        }

        public static int Mult(int x, int y)    // Methods multiplying 2 integers returning results.
        {
            return x * y;
        }

        // FLOATERS.
        public static float Add(float x, float y)   // Methods adding 2 floaters returning results.
        {
            return x + y;
        }

        public static float Sub(float x, float y)   // Methods subtracting 2 floaters returning results.
        {
            return x - y;
        }

        public static float Div(float x, float y)   // Methods dividing 2 floaters returning results.
        {
            return x / y;
        }

        public static float Mult(float x, float y)  // Methods multiplying 2 floaters returning results.
        {
            return x * y;
        }
    }

}
        