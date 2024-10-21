using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Calculator
    {
        public int Divide(int a, int b)
        {
            if(b == 0)
            {
                throw new DivideByZeroException("Dividing number cant'b be zero");
            }
            return a / b;
        }

        public void ProcessNumbers(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("Number can't be null");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    var result = Divide(numbers[i], 2);
                    Console.WriteLine($"Result: {result}");
                    Debug.WriteLine($"Processed number: {numbers[i]}, Result: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Debug.WriteLine($"Error processing number {numbers[i]}: {ex.Message}");
                }
            }
        }
    }
}
