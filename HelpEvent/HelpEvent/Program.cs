using System;

namespace HelpEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var console = new ConsoleSample();

            //イベントハンドラ
            void MyHelpEvent(object sender, EventArgs e)
            {
                var _sender = (ConsoleSample)sender;
                Console.WriteLine($"問題があったときは時間が知りたい。：{_sender.TimeNow}");

            }
            
            console.HelpEvent += MyHelpEvent;

            console.StartConsole();
        }
    }
}
