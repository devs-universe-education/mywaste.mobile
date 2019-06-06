using MyWasteMobile.BL.ViewModels.Map;

namespace MyWasteMobile.UI.Pages.PointInfo
{
	public partial class PointInfoPage : BasePage
	{
		public PointInfoPage ()
		{
			InitializeComponent ();

			BindingContext = new PointInfoViewModel();
		}
	}
}