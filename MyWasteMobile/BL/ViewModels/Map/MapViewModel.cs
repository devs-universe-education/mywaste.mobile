using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MyWasteMobile.BL.ViewModels.Map {

	public class MapViewModel : BaseViewModel {


		public ICommand GoToPointCommand => GetNavigateToCommand(AppPages.PointInfo);

		public ICommand FilterCommand => MakeCommand(OnSampleCommand);

		async void OnSampleCommand() {
			await ShowAlert("New alert", "Just a message", "OK");
		}

		private Position _myPosition = new Position(51.661518, 39.190122);
		public Position MyPosition { get { return _myPosition; } set { _myPosition = value; OnPropertyChanged(); } }

		private ObservableCollection<Pin> _pinCollection = new ObservableCollection<Pin>()
		{
			new Pin {Position = new Position(51.665526, 39.176226), Type = PinType.Generic, Label = "I'm a Pin"},
			new Pin {Position = new Position(51.697630, 39.194632), Type = PinType.Generic, Label = "I'm a Pin"},
			new Pin {Position = new Position(51.636469, 39.249251), Type = PinType.Generic, Label = "I'm a Pin"}
		};
	
		public ObservableCollection<Pin> PinCollection { get { return _pinCollection; } set { _pinCollection = value; OnPropertyChanged(); } }

		

	}
}
	

