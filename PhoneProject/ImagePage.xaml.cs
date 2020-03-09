using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhoneProject
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

          
            verizonButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new VerizonPage());
            };
            attButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new AttPage());
            };
           //image.Source = ImageSource.FromResource("PhoneProject.Images.background.jpg");
        }
    }
}
