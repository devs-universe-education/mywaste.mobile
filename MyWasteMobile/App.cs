using MyWasteMobile.DAL.DataServices;
using MyWasteMobile.UI;
using MyWasteMobile.UI.Pages.Introduction;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyWasteMobile
{
	public class App : Application
	{
		public App ()
		{
			DialogService.Init(this);
			NavigationService.Init(this);
			DataServices.Init(true);
		}

		protected override void OnStart ()
		{
			//NavigationService.Instance.SetMainTabbedPage(AppPages.Main, AppPages.Information, AppPages.Map, AppPages.RequestForm);
			NavigationService.Instance.SetMainPage(AppPages.Intro);
		}
	}
}

