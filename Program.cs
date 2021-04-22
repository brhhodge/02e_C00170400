// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02e

using System;

namespace _02e_C00170400
{
    class Program
    {
        delegate void MyDelegateType(double d);

        static void ShowAll(double[] b, MyDelegateType mdt)
        {
            for (int i = 0; i < b.Length; i++)
                mdt(b[i]);
        }

        static void ShowTwice(double d) => Console.WriteLine("Twice: " + d*2);

        static void ShowThrice(double d) => Console.WriteLine("Thrice: " + d*3);

        static void Quad(double d) => Console.WriteLine("Quad: " + d*4); //#2) static method "Quad"
        static void Main(string[] args)
        {
            double[] a = {1.1, 5.5, 9.9};

            MyDelegateType md = ShowTwice;
            md += ShowThrice;
            md += Quad;  //Add Quad to delegate md

            ShowAll(a, md);

            Console.WriteLine();


            var stopWatch = System.Diagnostics.Stopwatch.StartNew(); //#3) for loop to determine and output the elapsed time to calulate all of the cubes of first 10000 positive integers    
            int cubeThis;
            for (int i = 0; i < 10001; i++)  
            {
                if ((i*i*i) >= 0)
                {
                    cubeThis = i * i * i;
                    Console.WriteLine(cubeThis);
                }

            }
            var elapsedTime = stopWatch.Elapsed;
            Console.WriteLine("Elapsed Time: " + elapsedTime);
        
        }
    }
}
