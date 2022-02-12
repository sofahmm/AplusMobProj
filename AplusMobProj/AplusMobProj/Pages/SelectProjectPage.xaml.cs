using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectProjectPage : ContentPage
    {
        public string[] projects { get; set; }
        public SelectProjectPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            projects_lv.ItemsSource = App.ProjectDB.GetProjectAsync();
            base.OnAppearing();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.AddProjectPage());
        }

        private async void projects_lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new InformationProjectPage(projects_lv.SelectedItem.ToString()));
        }
    }
}