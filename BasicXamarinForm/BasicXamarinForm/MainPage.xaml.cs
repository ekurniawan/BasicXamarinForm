using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicXamarinForm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnShow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage(txtNama.Text));
        }

        private async void btnCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomListPage());
        }

        private async void menuCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomListPage());
        }

        private async void menuSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleBinding());
        }
    }
}
