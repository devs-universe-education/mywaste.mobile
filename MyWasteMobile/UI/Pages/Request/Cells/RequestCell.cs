using MyWasteMobile.UI.Controls.FastGrid;
using MyWasteMobile.UI.Pages.Request.DataObjects;
using Xamarin.Forms;

namespace MyWasteMobile.UI.Pages.Request.Cells {
	public class RequestCell : FastGridCell {
		Label _address;
		Label _waste;
		Label _status;

		protected override void InitializeCell() {
			var screenWidth = Device.Info.ScaledScreenSize.Width;

			_address = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				FontSize = 14,
				TextColor = Color.Black
			};

			_waste = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				FontSize = 14,
				TextColor = Color.Black
			};

			_status = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				FontSize = 14,
				TextColor = Color.Black
			};

			View = new StackLayout {
				Padding = 20,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children =
				{
					_address,
					_waste,
					_status
				}
			};
		}

		protected override void SetupCell(bool isRecycled) {
			if (!(BindingContext is RequestObject bindingContext)) return;

			_address.Text = bindingContext.Address;
			_waste.Text = bindingContext.Waste;
			_status.Text = bindingContext.Status;

		}
	}
}
