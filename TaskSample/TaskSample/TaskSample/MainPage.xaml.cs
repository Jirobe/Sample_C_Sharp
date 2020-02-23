using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaskSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            Task<bool> test01 = Test01();//走り始める
            bool result = test01.Result;//走り終わるまで待つ

            //bool test01 = await Test01();//走り始めと走り終わりが同じ

            Label01.Text = "最後まで行けた！";
        }

        private async Task<bool> Test01()
        {
            //Label01.Text = "最後の実行が関数Test01になってしまった";

            await Write();
            return true;
        }

        private Task Write() => Task.Run(()=>Label01.Text = "最後の実行が関数Test01になってしまった");

    }
}
