﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ComunicateInterdase : ContentPage
	{
		public ComunicateInterdase ()
		{
			InitializeComponent ();
		}

        private void Powrot(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CompanyComunicate());
        }
    }
}