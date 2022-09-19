using System;
namespace Lessons
{
    internal class Program
    {
        static void outputArray(ref int[] ArrayConsole, int i)
        {
            Console.WriteLine(ArrayConsole[ArrayConsole.Length - i]);
            if (i == ArrayConsole.Length)
                return;
            i++;
            outputArray(ref ArrayConsole, i);
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            outputArray(ref myArray, 1);
        }
    }
}