using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using BasicXamarinForm.Models;
using Newtonsoft.Json;

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

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.Username = txtNama.Text;
            await Navigation.PushAsync(new GridPage());
        }

        private async void btnPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("username", txtNama.Text);
            await DisplayAlert("Keterangan", "Preferences username berhasil dibuat", "OK");
        }

        private async void btnPreferenceJson_Clicked(object sender, EventArgs e)
        {
            var kon = new Konfigurasi
            {
                username = txtNama.Text,
                token = "111222333",
                expirationdate = DateTime.Now,
                brightnes = 70
            };

            //serialisasi class
            var strKon = JsonConvert.SerializeObject(kon);
            Preferences.Set("konfigurasi", strKon);
            await DisplayAlert("Keterangan", "Preferences Json berhasil disimpan","OK");
        }
    }
}
