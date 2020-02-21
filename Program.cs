using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixFromNeo
{
    class Program
    {
        const int STD_OUTPUT_HANDLE = -11;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleDisplayMode(IntPtr ConsoleHandle, uint Flags, IntPtr NewScreenBufferDimensions);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;

            var hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
            SetConsoleDisplayMode(hConsole, 1, IntPtr.Zero);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);

            var str1 = "Wake up, Neo...";
            str1.Print();

            var str2 = "The Matrix has you...";
            str2.Print();

            var str3 = "Follow the white rabbit.";
            str3.Print();

            var str4 = "Knock, knock, Neo.";
            str4.Print();
        }
    }
}
