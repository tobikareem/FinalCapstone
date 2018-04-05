using System.Windows.Input;
using FinalCap.View;
using Xamarin.Forms;

namespace FinalCap.ViewModel
{
    public class HelloViewModel
    {
        public string Message
        {
            get => "Hello World";
        }
        public HelloViewModel()
        {
            var navi = new NavigationService();
            GoToLoginCommand = new Command(async () =>
            {
                await navi.PushAsync(new AboutPage());
            });
        }

        public ICommand GoToLoginCommand { get; set; }
    }
}
