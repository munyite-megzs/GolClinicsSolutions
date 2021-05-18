using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 10,5,6,9};
            int count = 0;
            int length = A.Length-1;

            while (count < length)
            {
                var temp = A[count];
                A[count] = A[length];
                A[length] = temp;

                count++;
                length--;

            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
