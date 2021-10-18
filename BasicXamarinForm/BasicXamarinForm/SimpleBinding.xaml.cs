
using BasicXamarinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleBinding : ContentPage
    {
        public SimpleBinding()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Forms",Description="Learning xamarin forms",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg"},
                new ListItem{Title="ASP.NET Core",Description="Backend development with asp.net core",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg"},
                new ListItem{Title="Xamarin MVVM",Description="Frontend pattern with mvvm",
                PicUrl="https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg"}
            };
            lvData.ItemsSource = lstItems;
        }

        private void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (ListItem)e.Item;
            DisplayAlert("Selected Item", $"Anda memilih {item.Title}", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}