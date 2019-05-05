using MyWasteMobile.BL.ViewModels.Introduction;

namespace MyWasteMobile.UI.Pages.Introduction
	{
	public partial class IntroPage : BasePage
	{
		public IntroPage ()
		{
			InitializeComponent ();
			BindingContext = new IntroViewModel();
		}
	}
}