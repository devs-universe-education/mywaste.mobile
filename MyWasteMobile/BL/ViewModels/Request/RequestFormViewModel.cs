using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;

namespace MyWasteMobile.BL.ViewModels.Request
{
	public class RequestFormViewModel : BaseViewModel
	{
		public ICommand GoToInformationCommand => MakeMenuCommand(AppPages.Information);
		public ICommand GoToMapCommand => MakeMenuCommand(AppPages.Map);
		public ICommand GoToRequestFormCommand => MakeMenuCommand(AppPages.RequestForm);

		static ICommand MakeMenuCommand(object page) {
			return GetNavigateToCommand(page, NavigationMode.Root, newNavigationStack: true, withAnimation: false);
		}

		public ICommand GoToRequestHistoryCommand => GetNavigateToCommand(AppPages.RequestHistory);
	}
}