using System;
class Program
{
    static void Main(string[] args)
    {
        AddingNumbersClass.RunningTotalCalculator();
    }
    public class AddingNumbersClass
    {
        public static void RunningTotalCalculator()
        {
            Console.WriteLine("=== Running Total Calculator ===");
            Console.WriteLine("Enter numbers to add  the up. Enter 0 to finish");
            int num1 = 1;
            int currentTotal = 0;
            while (num1 != 0)
            {
                Console.Write("Enter a number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                    currentTotal += num1;
                    Console.WriteLine($"Current total: {currentTotal}");
                }
            }
            Console.WriteLine("==============================");
            Console.WriteLine($"Final Grand total: {currentTotal}");
            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
