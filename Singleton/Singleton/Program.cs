using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance().StringBuilder.AppendLine("Javaのような");
            Singleton.GetInstance().StringBuilder.AppendLine("シングルトン");

            Console.WriteLine(Singleton.GetInstance().StringBuilder.ToString());

            Abbreviation.Current.StringBuilder.AppendLine("静的な");
            Abbreviation.Current.StringBuilder.AppendLine("シングルトン");

            Console.WriteLine(Abbreviation.Current.StringBuilder.ToString());

            Console.ReadKey();
        }
    }
}
