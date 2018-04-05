using Xamarin.Forms;

namespace FinalCap
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
		{
			InitializeComponent();

            

		    switch (Device.RuntimePlatform)
		    {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.WinPhone:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                default:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
            }
		        


		}

	    
	}
}
