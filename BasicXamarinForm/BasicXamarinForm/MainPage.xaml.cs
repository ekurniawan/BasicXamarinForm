﻿using System;
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

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", $"Nama anda: {txtNama.Text}",
                "OK");
        }
    }
}