using System;

namespace Lesson1Exercise4
{
    public class L1Exercise4
    {
        static void Main()
        {
            string xx = Console.ReadLine(), 
                   yy = Console.ReadLine();
            char n = Convert.ToChar(Console.ReadLine());
            string combinedRow = string.Concat(xx, yy);
            Console.WriteLine($"Index of last {n} in {combinedRow}: " + combinedRow.LastIndexOf(n));
            Console.ReadKey();
        }
    }
}
