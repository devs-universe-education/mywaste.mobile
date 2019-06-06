using System.Windows.Input;

namespace MyWasteMobile.DAL.DataObjects
{
	public class BindableLocation
	{
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public ICommand ActionCommand { get; set; }
		public string LocationAddress { get; set; }

		public string LocationHours { get; set; }

	}
}
