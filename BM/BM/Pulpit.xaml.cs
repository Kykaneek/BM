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
    public partial class Pulpit : ContentPage
    {
        public Pulpit()
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
                new Menu { Title = "PULPIT", Icon = "menu.png" },
                new Menu { Title = "ZARZADZANIE KLIENTAMI", Icon = "z_customer.png" },
                new Menu { Title = "USŁUGI I TOWARY", Icon = "services.png" },
                new Menu { Title = "PRACOWNICY", Icon = "employers.png" },
                new Menu { Title = "BISUNESS MESSENGER", Icon = "messege.png" }
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

            Show();
        }

        private void MenuTapped(object sender, EventArgs e)
        {
            TitleTxt.Text = ((sender as StackLayout).BindingContext as Menu).Title;
            if (TitleTxt.Text == "BISUNESS MESSENGER")
            {
                Hide();
                Navigation.PushModalAsync(new CompanyComunicate());
            }
            else if (TitleTxt.Text == "ZARZADZANIE KLIENTAMI")
            {
                Hide();
                Navigation.PushModalAsync(new CustomersMenagment());
            }
            else if (TitleTxt.Text == "USŁUGI I TOWARY")
            {
                Hide();
                Navigation.PushModalAsync(new ServiceMenagment());
            }
            else if (TitleTxt.Text == "PRACOWNICY")
            {
                Hide();
                Navigation.PushModalAsync(new WorkersManagment());
            }
            else Hide();
        }




    }

    public class Menu
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }

}
