using System;

namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (; ; )
            {
                try
                {
                    Console.WriteLine("=================================================");
                    Console.WriteLine("  <1> Triangle\n  <2> Acute Triangle\n  <3> Inverted Acute Triangle\n  <4> Exit Program ");
                    Console.Write("  Enter shape: ");
                    string shape = Console.ReadLine();
                    switch (shape)
                    {
                        case "1":
                            Console.WriteLine("=================================================");
                            Console.Write("  Enter number of length: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("  THIS IS PYRAMID\n");

                            DrawPyramid(num);
                            break;
                        case "2":
                            Console.WriteLine("=================================================");
                            Console.Write("  Enter number of length: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("  THIS IS ACUTE TRIANGLE\n");

                            DrawAcuteTriangle(num1);
                            break;
                        case "3":
                            Console.WriteLine("=================================================");
                            Console.Write("  Enter number of length: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("  THIS IS  INVERTED ACUTE TRIANGLE\n");

                            DrawInvertedAcuteTriangle(num2);
                            break;
                        case "4":
                            Environment.Exit(0);
                            break;
                    }
                }
                catch
                {
                    Console.Write("======================================= ");
                    Console.Write("          INVALID TRY AGAIN ");
                }
            }
        }
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        static void DrawAcuteTriangle(int n)
        {
            for (int x = 0; x < n; x++)
            {
                for (int b = 0; b < x; b++)
                {
                    Console.Write(" " + "*");
                }

                Console.WriteLine();
            }
        }
        static void DrawInvertedAcuteTriangle(int n)
        {
            for (int x = 1; x <= n; x++)
            {

                for (int o = (n - x); o >= 0; o--)
                {

                    Console.Write("  *");
                }
                for (int a = 0; a < x; a++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
