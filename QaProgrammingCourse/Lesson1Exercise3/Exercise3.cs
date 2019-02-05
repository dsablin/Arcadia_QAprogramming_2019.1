using System;

namespace Lesson1Exercise3
{
    public class Exercise3
    {
        static void Main()
        {
            string xx = Console.ReadLine().ToUpperInvariant(),
                yy = Console.ReadLine().ToUpperInvariant(),
                zz = Console.ReadLine().ToUpperInvariant();

            Console.WriteLine($"String {xx} starts from {yy}: { xx.StartsWith(yy) }");
            Console.WriteLine($"String {xx} ends with {zz}: { xx.EndsWith(zz) }");
            Console.ReadKey();
        }
    }
}
