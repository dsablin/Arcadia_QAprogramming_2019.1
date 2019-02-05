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
            Console.WriteLine(@"Parallelepiped diagonal length: {0}", Math.Sqrt(a * a + b * b + c * c));
            Console.ReadKey();
        }
    }
}
