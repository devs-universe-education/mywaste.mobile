using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;

namespace MyWasteMobile.BL.ViewModels.Information
{
	public class InformationViewModel : BaseViewModel
	{
		public ICommand GoToAboutCommand => GetNavigateToCommand(AppPages.About);
		public ICommand GoToNewsItemCommand => GetNavigateToCommand(AppPages.NewsItem);

	}
}