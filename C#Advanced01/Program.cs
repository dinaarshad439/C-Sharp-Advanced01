namespace C_Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (Q1) Generic class defination 

            // A generic class is a class designed to handle any data type,
            // and generics are used to reduce code redundancy

            #endregion

            #region (Q3) Multiple type Parameter

            //Means that we can add more than one generic type.

            #endregion

            #region (Q4) Generic method definition

            // Generic method is a method that could handle any data type.

            //int x = 10;
            //int y = 20;
            //Swap<int>(ref x, ref y);
            //Console.WriteLine($"X:{x}");
            //Console.WriteLine($"y:{y}");

            #endregion

            #region (Q5) Calling Find Max

            int[] arr = { 10, 20, 100, 50 };
            FindMax<int>(arr);

           

            #endregion


        }


        // Q4
        /// <summary>
        /// Swaps the values of two variables of type <typeparamref name="T"/> using a temporary variable.
        /// </summary>
        /// <typeparam name="T">The type of the values being swapped.</typeparam>
        /// <param name="num1">The first value to swap.</param>
        /// <param name="num2">The second value to swap.</param>
        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }

        //Q5
        /// <summary>
        /// Finds and returns the maximum value in an array of elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, which must implement IComparable.</typeparam>
        /// <param name="items">The array of items to search through.</param>
        /// <returns>The maximum value found in the array.</returns>
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            T Max = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(Max)>0) Max=items[i];
            }
            
            Console.WriteLine($"Max: {Max}");
            return Max;
            
        }
    }
}
