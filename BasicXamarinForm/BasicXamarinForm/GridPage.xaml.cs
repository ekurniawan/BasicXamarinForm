using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarinForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            /*myImage.Source = 
                ImageSource.FromFile(Path.Combine("images", "monyet1.png"));*/
            myImage.Source = ImageSource.FromUri(
                new Uri("https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg"));
        }

        private string _nama;
        public GridPage(string nama)
        {
            InitializeComponent();
            myImage.Source = ImageSource.FromUri(
                new Uri("https://i0.wp.com/blog.mzikmund.com/wp-content/uploads/2019/02/microsoft-xamirin-1.jpg"));
            _nama = nama;

            var arrNama = _nama.Split(' ');
            txtFirstName.Text = arrNama[0];
            txtLastName.Text = arrNama[1];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (myStackLayout.IsVisible)
                myStackLayout.IsVisible = false;
            else
                myStackLayout.IsVisible = true;
        }
    }
}