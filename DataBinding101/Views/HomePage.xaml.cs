﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBinding101
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

			BindingContext = new DetailsViewModel ();
		}
	}
}
