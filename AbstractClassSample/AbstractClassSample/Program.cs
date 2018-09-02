using AbstractClassSample.AbstractClass;
using AbstractClassSample.SubClass;
using System;

namespace AbstractClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Semi AburaSemi = new AburaSemi();
            Console.WriteLine($"アブラゼミの鳴き声：{AburaSemi.Shrill()}");

            Semi MinminSemi = new MinminSemi();
            Console.WriteLine($"ミンミンゼミの鳴き声：{MinminSemi.Shrill()}");

            Console.ReadKey();
        }
    }
}
