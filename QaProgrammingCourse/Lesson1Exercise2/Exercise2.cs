using System;

namespace Lesson1Exercise2
{
    public class Exercise2
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            double d = Math.Sqrt(a*a + b*b + c*c);
            Console.WriteLine($"Parallelepiped diagonal length: {d}");
            Console.ReadKey();
        }
    }
}
