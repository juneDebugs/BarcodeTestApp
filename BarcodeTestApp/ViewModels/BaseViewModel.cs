using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BarcodeTestApp
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

		ImageSource localSource = "icon.png";
		string path = "";
		ICommand takePhotoCommand;

		public ICommand TakePhotoCommand
		{
			get { return takePhotoCommand ?? (takePhotoCommand = new Command(async () => await TakePhoto())); }
		}

		public ImageSource LocalImageSource
		{
			get { return localSource; }
			set
			{
				localSource = value;
				OnPropertyChanged();
			}
		}

		public string Path
		{
			get { return path; }
			set
			{
				if (path == value)
					return;
				path = value;
				OnPropertyChanged();
			}
		}

		public async Task TakePhoto()
		{
			//IsLoading = true;

			var scanner = new ZXing.Mobile.MobileBarcodeScanner();


			var result = await scanner.Scan();

			if (result != null)
			{
				System.Diagnostics.Debug.WriteLine("Scanned Barcode: " + result.Text);
				Path = result.Text;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
