using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;
using Xamarin.Forms;

namespace MyWasteMobile.BL.ViewModels.Information
{
	public class InformationViewModel : BaseViewModel
	{
		public ICommand GoToAboutCommand => GetNavigateToCommand(AppPages.About);
		public ICommand GoToNewsItemCommand => GetNavigateToCommand(AppPages.NewsItem);

		public ICommand WebCommand => MakeCommand(OnSampleCommand);

		async void OnSampleCommand() {
			Device.OpenUri(new Uri("https://github.com/binwell-university"));
		}
	}
}