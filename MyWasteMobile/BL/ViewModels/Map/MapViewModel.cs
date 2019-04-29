using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;

namespace MyWasteMobile.BL.ViewModels.Map
{
	public class MapViewModel : BaseViewModel
	{
		public ICommand GoToPointCommand => GetNavigateToCommand(AppPages.PointInfo);
	}
}