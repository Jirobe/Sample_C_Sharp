using System;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {

            #region DelegateTest
            DelegateTest d = new DelegateTest(Test);
            d("Delegate");

            //ラムダ1
            d = new DelegateTest((string s) => { Console.WriteLine($"This is {s}"); });
            d("Delegate");

            //ラムダ2
            d = new DelegateTest(s => Console.WriteLine($"This is {s}"));
            d("Delegate");
            #endregion

            #region Action
            Action<string> a = Test;
            a("Action");

            a = s => Console.WriteLine($"This is {s}");
            a("Action");
            #endregion

            #region Func
            Func<string> f = Test2;
            Console.WriteLine($"{f()} Func");

            f = () => "This is";//引数のないラムダ式は()を省略できない
            Console.WriteLine($"{f()} Func");

            Func<string, string> ff = Test3;
            Console.WriteLine(ff("Func"));

            ff = s => $"This is {s}";
            Console.WriteLine(ff("Func"));
            #endregion

            Console.ReadKey();
        }

        delegate void DelegateTest (string s);


        static void Test(string s)
        {
            Console.WriteLine($"This is {s}");
        }

        static string Test2()
        {
            return "This is";
        }

        static string Test3(string s)
        {
            return $"This is {s}";
        }
    }
}
