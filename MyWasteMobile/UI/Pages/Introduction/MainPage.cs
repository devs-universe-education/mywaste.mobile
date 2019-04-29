using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace MyWasteMobile.UI.Pages.Introduction
{
	public class MainPage : BaseTabbedPage {
		public MainPage() {
			On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
			On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(true);
			On<Xamarin.Forms.PlatformConfiguration.Android>().SetBarItemColor(Color.CornflowerBlue);
		}

		protected override void OnCurrentPageChanged() {
			Title = CurrentPage?.Title;
			base.OnCurrentPageChanged();
		}
	}
}
