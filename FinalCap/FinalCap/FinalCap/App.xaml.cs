using FinalCap.Model;
using FinalCap.Services;
using FinalCap.View;
using Xamarin.Forms;

namespace FinalCap
{
    public partial class App : Application
	{
        /** A much better way to maintain page state when a page is invoked several times in succession is to
         * add a property to the App page for the viewmodel class and instantiate that class in the App constructor:
         */

        public SignInfoModel ModelInfo { get; private set; }
	    public static string DepartmentUrl = "http://localhost:61073";
 


        public App ()
		{
			InitializeComponent();
		    ModelInfo = new SignInfoModel();

		    MainPage = new NavigationPage(new SignIn());
		   
        }
        

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
