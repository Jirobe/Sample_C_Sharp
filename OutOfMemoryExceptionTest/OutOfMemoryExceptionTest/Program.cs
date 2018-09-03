using System;
using System.Collections.Generic;

namespace OutOfMemoryExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> List_int = new List<int>();
            int i = 0;
            while (true)
            {
                try
                {
                    List_int.Add(i);

                    //数字は初期化したら"index初期化"が表示されて初期化しなかったら表示されないくらいに調節してください
                    if (i++ > 1000000)
                    {
                        i = 0;
                        Console.WriteLine("index初期化");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Exception:{e.ToString()}");

                    Console.WriteLine("1が入力されたらオブジェクトを初期化");
                    Console.WriteLine("press any key.");


                    if (Console.Read() == 49)
                    {
                        List_int = new List<int>();

                    }

                    Console.WriteLine("GC.Collect();");
                    GC.Collect();

                }
            }

        }
    }
}
