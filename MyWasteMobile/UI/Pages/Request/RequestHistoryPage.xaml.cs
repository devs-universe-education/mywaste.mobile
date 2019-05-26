using MyWasteMobile.BL.ViewModels.Request;
using MyWasteMobile.UI.Controls.FastGrid;
using MyWasteMobile.UI.Pages.Request.Cells;
using MyWasteMobile.UI.Pages.Request.DataObjects;
using Xamarin.Forms;

namespace MyWasteMobile.UI.Pages.Request {
	public partial class RequestHistoryPage : BasePage {
		public RequestHistoryPage()
		{
			InitializeComponent();

			var size = Device.Info.ScaledScreenSize;
			fastGridView.ItemTemplateSelector = new FastGridTemplateSelector(
				new FastGridDataTemplate(typeof(CategoryObject).Name, typeof(CategoryCell), new Size(size.Width, 60)),
				new FastGridDataTemplate(typeof(RequestObject).Name, typeof(RequestCell), new Size(size.Width, 150))
			);

			BindingContext = new RequestHistoryViewModel();
		}
	}
}