using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((CompanyID.Text == "9876543210") && (CompanyPW.Text == "CompanyPW"))
            {
                DisplayAlert("Uwaga", "Zalogowano!", "Close");
            }
            else
            {
                DisplayAlert("Uwaga", "Błędne dane!", "Close");
            } 
        }


        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
    
        }
    }
}
