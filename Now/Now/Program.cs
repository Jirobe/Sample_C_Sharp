using System;
using System.Linq;
using System.Threading;

namespace Now
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                //引数なし
                Console.WriteLine(DateTime.Now);
            }
            else
            {
                #region 引数判別
                bool isMillisecond = args.Where(s => s == "/m").Count() > 0;
  
                var query = args
                            .Select((v, i) => new { Value = v, Index = i })
                            .Where(s => s.Value == "/n")
                            .Select(s => s.Index);

                int nOptIndex = 0;
                if (query.Count() > 0) nOptIndex = query.First();

                bool isLoop = args.Length > nOptIndex + 1 && query.Count() > 0;
                #endregion 引数判別

                //ヘルプ
                if (args.Where(s => s == "/?").Count() > 0)
                {
                    Console.WriteLine(HelpStr);
                    return;
                }

                #region 処理
                if (isLoop)
                {
                    if (int.TryParse(args[nOptIndex + 1], out int count))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (i > 99) return;

                            WriteLine(isMillisecond);

                            Thread.Sleep(1000);

                        }
                    }
                    else
                    {
                        Console.WriteLine(HelpStr);
                        return;
                    }
                }
                else
                {
                    WriteLine(isMillisecond);
                }
                #endregion 処理

            }
        }

        private static void WriteLine(bool isMillisecond)
        {
            if (isMillisecond)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff"));
            }
            else
            {
                Console.WriteLine(DateTime.Now);
            }
        }

        private const string HelpStr = @"
現在時刻を表示します。

引数なしの場合、yyyy/MM/dd HH:mm:ssで表示します。
引数は順不同

/m  yyyy/MM/dd HH:mm:ss.ff形式で表示します。
/n [0-99] 指定した回数だけ表示を繰り返します。
";
    }
}
