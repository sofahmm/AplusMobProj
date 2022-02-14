using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void btm_registrat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.AuthorizationPage());
        }
    }
}