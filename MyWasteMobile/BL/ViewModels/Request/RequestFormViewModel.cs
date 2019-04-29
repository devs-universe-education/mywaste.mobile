using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;

namespace MyWasteMobile.BL.ViewModels.Request
{
	public class RequestFormViewModel : BaseViewModel
	{
		public ICommand GoToRequestHistoryCommand => GetNavigateToCommand(AppPages.RequestHistory);
	}
}