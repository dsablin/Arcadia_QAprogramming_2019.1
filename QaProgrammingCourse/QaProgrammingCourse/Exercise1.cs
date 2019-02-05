using System;

namespace QaProgrammingCourse
{
    public class Exercise1
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine()),
                z = int.Parse(Console.ReadLine());

            Console.WriteLine($"First expression result: {(x + y) * (Math.Pow(2, z) + 1)}");
            Console.WriteLine($"Second expression result: {(x % z - 1) * Math.Sqrt(y)}");
            Console.WriteLine($"Third expression result: {(x * y + y * z) / Math.Pow(3, z)}");
            Console.ReadKey();
        }
    }
}
