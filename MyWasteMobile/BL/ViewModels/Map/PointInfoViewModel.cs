using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MyWasteMobile.DAL.DataObjects;
using MyWasteMobile.DAL.DataServices;
using Plugin.Messaging;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyWasteMobile.BL.ViewModels.Map
{
	public class PointInfoViewModel : BaseViewModel
	{
		private string pointphone = "+8960051651561";

		public ICommand MakeCall => MakeCommand(OnCallCommand);


		async void OnCallCommand() {
			var phoneDialer = CrossMessaging.Current.PhoneDialer;
			var answer = false;

			if (phoneDialer.CanMakePhoneCall)
				answer = await ShowQuestion("Набрать номер горячей линии?", pointphone, "Да", "Нет");
			if (answer)
				phoneDialer.MakePhoneCall(pointphone);
		}

	}
}