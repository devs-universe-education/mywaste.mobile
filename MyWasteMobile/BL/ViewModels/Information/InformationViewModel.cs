using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyWasteMobile.BL.ViewModels.Information
{
	public class InformationViewModel : BaseViewModel
	{
		public ICommand GoToAboutCommand => GetNavigateToCommand(AppPages.About);
		public ICommand GoToNewsItemCommand => GetNavigateToCommand(AppPages.NewsItem);

		public ICommand WebCommand => MakeCommand(OnWebCommand);

		async void OnWebCommand() {
			//Device.OpenUri(new Uri("https://github.com/binwell-university"));
			await Browser.OpenAsync("https://github.com/binwell-university", new BrowserLaunchOptions {
				LaunchMode = BrowserLaunchMode.SystemPreferred,
				TitleMode = BrowserTitleMode.Show,
				PreferredToolbarColor = Color.AliceBlue,
				PreferredControlColor = Color.Violet
			});
		}
	}
}