using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_C_Sharp__IP02
{
    class Program
    {
        static void Main(string[] args)
        {
            //   2 варіант

            double squareArea = 20; // площа заданого квадрата
            Console.WriteLine($"Square Area - {squareArea}");

            double squareSide = Math.Sqrt(squareArea);
            double radius = squareSide / 2;// шукаємо радіус кола вписаного в данний квадрат
            Console.WriteLine($"Circle Inscribed In Square Area - {Math.Pow(radius, 2) * 3.14}");

            double smallSquareSide = Math.Sqrt(2) * radius; // шукаємо сторону квадрата вписаного в коло
            double smallSquareArea = Math.Pow(smallSquareSide, 2); // шукаємо площу квадрата вписаного в коло
            Console.WriteLine($"Square Inscribed In Circle Area - {smallSquareArea}");

            double a = squareArea / smallSquareArea;
            Console.WriteLine($"The area of the insribed square is  {a} times less than given square area");
        }
    }
}
