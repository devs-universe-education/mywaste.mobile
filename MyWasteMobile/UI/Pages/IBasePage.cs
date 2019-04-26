using MyWasteMobile.BL.ViewModels;

namespace MyWasteMobile.UI.Pages
{
	interface IBasePage {
		string Title { get; set; }
		void SetViewModel(BaseViewModel viewModel);
	}
}