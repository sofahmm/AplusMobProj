using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusMobProj.Models;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationProjectPage : TabbedPage
    {
        public InformationProjectPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            EditProjectPage projectPage = new EditProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
            //await Navigation.PushAsync(new Pages.EditProjectPage());
        }
    }
}