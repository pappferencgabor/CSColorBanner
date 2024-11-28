using System.Drawing;
using Banner.Models;

namespace Banner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('■');
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine('■');

            UBanner kep = new UBanner();
            kep[2, 5] = Color.Blue;
        }
    }
}
