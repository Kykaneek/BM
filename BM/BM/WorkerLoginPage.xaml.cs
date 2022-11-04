using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkerLoginPage : ContentPage
    {
        public WorkerLoginPage()
        {
            InitializeComponent();
        }

        private void Zaloguj_Clicked(object sender, EventArgs e)
        {
            if ((Login.Text == "Boss") && (Password.Text == "BossPW"))
            {
                Navigation.PushModalAsync(new Pulpit());
            }
            else
            {
                DisplayAlert("Uwaga", "Błędne dane!", "Close");
            }
        }
    }
}