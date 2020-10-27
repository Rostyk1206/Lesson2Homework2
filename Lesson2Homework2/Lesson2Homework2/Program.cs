using System;

namespace Lesson2Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z;
            z = --x- y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;

            Console.WriteLine($"Result is:\nx += y - x++ * z={x += y - x++ * z}\nz = --x- y * 5={z = --x - y * 5}\ny /= x + 5 % z={y /= x + 5 % z}\nz = x++ + y * 5={z = x++ + y * 5}\nx = y - x++ * z={x = y - x++ * z}");
        }
    }
}