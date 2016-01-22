﻿using System;
using System.ComponentModel;

namespace DataBinding101
{
	public class DetailsViewModel : INotifyPropertyChanged
	{
		string forename, surname;

		public string Forename { 
			get {
				return forename;
			}
			set {
				if (forename != value) {
					forename = value;
					OnPropertyChanged ("Forename");
				}
			}
		}

		public string Surname { 
			get {
				return surname;
			}
			set {
				if (surname != value) {
					surname = value;
					OnPropertyChanged ("Surname");
				}		
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged (string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}
