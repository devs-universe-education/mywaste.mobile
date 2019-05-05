using System.Collections.Generic;
using System.Windows.Input;

namespace MyWasteMobile.BL.ViewModels.Introduction
	{
	public class IntroViewModel : BaseViewModel
	{


		public ICommand GoToInfoCommand => MakeMenuCommand(AppPages.Information);

		static ICommand MakeMenuCommand(object page) {
			return GetNavigateToCommand(page, NavigationMode.Root, newNavigationStack: false, withAnimation: false);
		}


		public List<Slide> Slides { get; } = new List<Slide>()
		{
			new Slide("icon.png", "Я разделяю это сервис для тех, кто заботится об экологии и будущем наших детей"),
			new Slide("icon.png", "Я разделяю это сервис для тех, кто заботится об экологии и будущем наших детей"),
			new Slide("icon.png", "Я разделяю это сервис для тех, кто заботится об экологии и будущем наших детей"),
		};
	}

	public class Slide {
		public string Image { get; set; }
		public string Description { get; set; }

		public Slide(string image, string description) {
			Image = image;
			Description = description;
		}
	}
}