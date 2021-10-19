using BasicXamarinForm.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomListPage : ContentPage
    {
        public CustomListPage()
        {
            InitializeComponent();

            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Forms",Description="Learning xamarin forms",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg",
                Price=2000000},
                new ListItem{Title="ASP.NET Core",Description="Backend development with asp.net core",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg",
                Price=1500000},
                new ListItem{Title="Xamarin MVVM",Description="Frontend pattern with mvvm",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg",
                Price=2500000}
            };
            lvData.ItemsSource = lstItems;
        }

        private void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (ListItem)e.Item;
            DisplayAlert("Selected ITem", $"You select {item.Title} - {item.Price}", "OK");
        }

        private async void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SimpleBinding());
        }

        private async void btnAmbilPreferences_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("username"))
            {
                await DisplayAlert("Keterangan",
                    $"Data Username: {Preferences.Get("username", string.Empty)}", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", $"Preferences Username tidak ditemukan","OK");
            }
        }

        private async void btnDeletePreferences_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("username"))
            {
                Preferences.Remove("username");
                Preferences.Clear();
                await DisplayAlert("Keterangan", "Preferences sudah terhapus", "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", $"Preferences Username tidak ditemukan", "OK");
            }
        }

        private async void btnPrefJson_Clicked(object sender, EventArgs e)
        {
            if (Preferences.ContainsKey("konfigurasi"))
            {
                var data = Preferences.Get("konfigurasi", string.Empty);
                if (!string.IsNullOrEmpty(data)) {
                    var kon = JsonConvert.DeserializeObject<Konfigurasi>(data);
                    await DisplayAlert("Keterangan",
                        $"{kon.username} - {kon.token} - {kon.expirationdate.ToShortDateString()} - {kon.brightnes}", "OK");
                }
            }
            else
            {
                await DisplayAlert("Keterangan", "Preferences Username tidak ditemukan", "OK");
            }
        }
    }
}