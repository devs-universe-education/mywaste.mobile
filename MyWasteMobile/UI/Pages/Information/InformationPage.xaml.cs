using MyWasteMobile.BL.ViewModels.Information;

namespace MyWasteMobile.UI.Pages.Information
{
	public partial class InformationPage : BasePage
	{
		public InformationPage ()
		{
			InitializeComponent ();
			BindingContext = new InformationViewModel();
		}
	}
}