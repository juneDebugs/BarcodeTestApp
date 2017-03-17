using System;
using Xamarin.Forms;
namespace BarcodeTestApp
{
	public class OurLandingPage : ContentPage
	{
		public OurLandingPage()
		{
			var image = new Image();
			var pathLabel = new Label();
			var button = new Button { Text = "Take Picture", };
			//curly brakets define inline with the constructor
			//CTRL + SpaceBar shoes all properties 

			Content = new StackLayout
			{
				Children = 
				{
					image,
					pathLabel,
					button
				}
			};


		}
	}
}
