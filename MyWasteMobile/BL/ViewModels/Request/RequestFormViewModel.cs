using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;
using MyWasteMobile.UI.Pages.Request.DataObjects;
using Plugin.Media;
using Xamarin.Forms;

namespace MyWasteMobile.BL.ViewModels.Request
{
	public class RequestFormViewModel : BaseViewModel
	{
		public ICommand GoToRequestHistoryCommand => GetNavigateToCommand(AppPages.RequestHistory);
		public ICommand MakeRequestCommand => MakeCommand(TestCommand);

		public ICommand CameraCommand => MakeCommand(OnCameraCommand);

		//ICommand _MakeRequest;

		//public ICommand MakeRequestCommand => _MakeRequest ??
		//									   (_MakeRequest = new Command(async (o) =>
		//										   await ItemSelectedCommandAsync(o)));

		Image _img = new Image();


		string selectedwaste;
		public string SelectedWaste
		{
			get { return selectedwaste; }
			set { selectedwaste = value; }
		}

		string selectedvalue;
		public string SelectedValue {
			get { return selectedvalue; }
			set { selectedvalue = value; }
		}

		string userphone;
		public string UserPhone {
			get { return userphone; }
			set { userphone = value; }
		}

		string username;
		public string UserName {
			get { return username; }
			set { username = value; }
		}

		async void TestCommand()
		{
			if (selectedwaste == null || selectedvalue == null || userphone == null || username == null)
			{
				await ShowAlert("Вы должны заполнить все поля", "", "ок");
			}
			else
			{
				await ShowAlert("Поля заполнены", "asdasd", "OK");
				//await NavigateTo(AppPages.RequestHistory, NavigationMode.Normal);
				NavigateTo(AppPages.RequestHistory);
				//await Application.Current.MainPage.DisplayAlert("Поля заполнены", "", "ок");
				//GetNavigateToCommand(AppPages.RequestHistory);
				//await NavigateTo(AppPages.RequestHistory, NavigationMode.Normal);
			}
		}

		public string StatusText { get; } = "Добавьте, пожалуйста, фотографию вторсырья, чтобы нам было проще подобрать автомобиль";

		public ImageSource someImage {
			get { return ImageSource.FromFile("icon.png"); }
			set { someImage = value; }
		}

		

		async void OnCameraCommand() {
			await CrossMedia.Current.Initialize();
			if(!CrossMedia.Current.IsTakePhotoSupported && !CrossMedia.Current.IsPickPhotoSupported) {
				await ShowAlert("New alert", "Photo capture  and pick are not supported", "OK");
				return;
			}
			else
			{
				var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions {
					SaveToAlbum = true,
					Directory = "Sample",
					Name = "test.jpg"
				});
				if (file == null)
					return;

				await ShowAlert("File Location", file.Path, "OK");

				_img.Source = ImageSource.FromFile(file.Path);
							
			}

		}
	

	}
}