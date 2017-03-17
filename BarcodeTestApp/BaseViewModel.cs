using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BarcodeTestApp
{
	public class BaseViewModel : INotifyPropertyChanged 
	//I = Capital I defines a interface
	{
		public BaseViewModel()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
