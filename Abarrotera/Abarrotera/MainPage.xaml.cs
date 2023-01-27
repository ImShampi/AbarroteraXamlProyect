using Abarrotera.Pages.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Abarrotera
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void NavMenu(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mainMenu());
        }

    }
}
