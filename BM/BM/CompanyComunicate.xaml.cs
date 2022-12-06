using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompanyComunicate : ContentPage
    {
        public CompanyComunicate()
        {
            InitializeComponent();
            MenuItems = GetMenus();
            this.BindingContext = this;
        }
        
        public ObservableCollection<Menu> MenuItems { get; set; }


        private ObservableCollection<Menu> GetMenus()
        {
            return new ObservableCollection<Menu>
            {
                new Menu { Title = "BIUSSNES MESSENGER", Icon = "activity.png" },
                new Menu { Title = "PULPIT", Icon = "menu.png" },
                new Menu { Title = "ZARZADZANIE KLIENTAMI", Icon = "z_customer.png" },
                new Menu { Title = "USŁUGI I TOWARY", Icon = "services.png" },
                new Menu { Title = "PRACOWNICY", Icon = "employers.png" },

            };
        }



        private async void Show()
        {
            _ = TitleTxt.FadeTo(0);
            _ = MenuItemsView.FadeTo(1);
            await MainMenuView.RotateTo(0, 300, Easing.BounceOut);
        }

        private async void Hide()
        {
            _ = TitleTxt.FadeTo(1);
            _ = MenuItemsView.FadeTo(0);
            await MainMenuView.RotateTo(-90, 300, Easing.BounceOut);
        }

        private void ShowMenu(object sender, EventArgs e)
        {
            TitleTxt.Text = "BM";
            Show();
        }

        private void MenuTapped(object sender, EventArgs e)
        {
            TitleTxt.Text = ((sender as StackLayout).BindingContext as Menu).Title;
            if (TitleTxt.Text == "PULPIT")
            {
                Hide();
                Navigation.PushModalAsync(new Pulpit());
            }
            else if (TitleTxt.Text == "ZARZADZANIE KLIENTAMI")
            {
                Hide();
                Navigation.PushModalAsync(new ClientMenagment());
            }
            else if (TitleTxt.Text == "USŁUGI I TOWARY")
            {
                Hide();
                Navigation.PushModalAsync(new CustomerAndServicesManagment());
            }
            else if (TitleTxt.Text == "PRACOWNICY")
            {
                Hide();
                Navigation.PushModalAsync(new WorkersManagment());
            }
            else Hide();
        }

        private void GoToMessenger(object sender, EventArgs e) => Navigation.PushModalAsync(new ComunicateInterdase());
    }

}
