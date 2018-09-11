using System;

namespace HelpEvent
{
    class ConsoleSample
    {
        public EventArgs e;
        public EventHandler HelpEvent;
        public string TimeNow => DateTime.Now.ToString();

        public void StartConsole()
        {
            Console.WriteLine("問題はありますか？(y/n)");

            if (Console.ReadKey().KeyChar == 'y')
            {
                Console.WriteLine("\r\n問題がありました。HelpEventを実行します");
                Console.WriteLine("Start");
                HelpEvent(this, e);
                Console.WriteLine("End");
            }
            else
            {
                Console.WriteLine("問題はありませんでした。");
            }

            Console.WriteLine("終了します。何かキーを押下してください。");
            Console.ReadKey();
        }
    }
}
