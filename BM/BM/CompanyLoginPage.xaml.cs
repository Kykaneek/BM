using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BM
{
    public partial class CompanyLoginPage : ContentPage
    {
        public CompanyLoginPage()
        {
            InitializeComponent();

            
        }

        private void Zaloguj_Button_Clicked(object sender, EventArgs e)
        {
            
            if ((CompanyID.Text == "9876543210") && (CompanyPW.Text == "CompanyPW"))
            {
                Navigation.PushModalAsync(new Pulpit());
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
