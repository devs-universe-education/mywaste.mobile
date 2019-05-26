using MyWasteMobile.UI.Controls.FastGrid;
using Xamarin.Forms.Xaml;

namespace MyWasteMobile.UI.Pages.Request.Cells {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryCell : FastGridCell {
		protected override void InitializeCell() {
			InitializeComponent();
		}

		protected override void SetupCell(bool isRecycled) {
		}
	}
}