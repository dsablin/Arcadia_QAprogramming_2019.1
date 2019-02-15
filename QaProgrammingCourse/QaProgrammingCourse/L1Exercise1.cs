using System;

namespace QaProgrammingCourse
{
    public class L1Exercise1
    {
        static bool IsNumber(string ss, out int i)
        {
            return int.TryParse(ss, out i);
        }

        static void Main()
        {
            if (!IsNumber(Console.ReadLine(), out int x) ||
                !IsNumber(Console.ReadLine(), out int y) ||
                !IsNumber(Console.ReadLine(), out int z))
            {
                Console.WriteLine("Not an integer number entered!");
                return;
            }

            Console.WriteLine($"First expression result: {(x + y) * (Math.Pow(2, z) + 1)}");
            Console.WriteLine($"Second expression result: {(x % z - 1) * Math.Sqrt(y)}");
            Console.WriteLine($"Third expression result: {(x * y + y * z) / Math.Pow(3, z)}");
            Console.ReadKey();
        }
    }
}
