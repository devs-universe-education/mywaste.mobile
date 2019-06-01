using MyWasteMobile.BL.ViewModels.Request;

namespace MyWasteMobile.UI.Pages.Request
{
	public partial class RequestFormPage : BasePage
	{
		public RequestFormPage ()
		{
			InitializeComponent ();

			BindingContext = new RequestFormViewModel();
		}
	}
}