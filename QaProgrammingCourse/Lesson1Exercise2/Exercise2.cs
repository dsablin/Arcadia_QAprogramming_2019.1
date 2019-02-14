using System;

namespace Lesson1Exercise2
{
    public class Exercise2
    {
        static int SideLength()
        {
            int sideLength;
            while (!int.TryParse(Console.ReadLine(), out sideLength))
            {
                Console.WriteLine("Incorrect number.\nPlease try again:");
            }
            return sideLength;
        }

        static void Main()
        {
            int a = SideLength(),
                b = SideLength(),
                c = SideLength();

            double d = Math.Sqrt(a*a + b*b + c*c);
            Console.WriteLine($"Parallelepiped diagonal length: {d}");
            Console.ReadKey();
        }
    }
}
