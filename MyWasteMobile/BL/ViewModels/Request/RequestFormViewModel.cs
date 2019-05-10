using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;
using Plugin.Media;
using Xamarin.Forms;

namespace MyWasteMobile.BL.ViewModels.Request
{
	public class RequestFormViewModel : BaseViewModel
	{
		public ICommand GoToRequestHistoryCommand => GetNavigateToCommand(AppPages.RequestHistory);

		public ICommand CameraCommand => MakeCommand(OnCameraCommand);


		Image _img = new Image();


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