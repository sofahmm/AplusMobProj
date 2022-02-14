using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private async void btn_registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.RegistrationPage());
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SelectProjectPage());
        }
    }
}