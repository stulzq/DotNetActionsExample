namespace TestLib
{
    /// <summary>
    /// Represents a class with methods to perform addition and subtraction operations.
    /// </summary>
    public class MyClass
    {
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">The first integer to add.</param>
        /// <param name="b">The second integer to add.</param>
        /// <returns>The sum of the two integers.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts one integer from another and returns the result.
        /// </summary>
        /// <param name="a">The integer to subtract from (the minuend).</param>
        /// <param name="b">The integer to subtract (the subtrahend).</param>
        /// <returns>The difference between the two integers.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}