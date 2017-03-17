using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace BarcodeTestApp
{
	public class BaseViewModel : INotifyPropertyChanged
	//I = Capital I defines a interface
	{
		public BaseViewModel()
		{
		}

		ImageSource localSource = "icon.png";
		string path = "";
		ICommand takePhotoCommand;
		//Capital I = Interface !!

		public ImageSource LocalImageSource
		{
			get { return localSource; }
			set
			{
				localSource = value;
				OnPropertyChanged();
			}
		}



		public async Task TakePhoto()
		{

		}



		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
