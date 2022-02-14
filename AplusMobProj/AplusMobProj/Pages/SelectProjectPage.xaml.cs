using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusMobProj.Models;

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
            projects_lv.ItemsSource = App.ProjectDB.GetProject();
            base.OnAppearing();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Project project = new Project();
            AddProjectPage projectPage = new AddProjectPage();
            projectPage.BindingContext = project;
            await Navigation.PushAsync(projectPage);
            // await Navigation.PushAsync(new Pages.AddProjectPage());
        }

        private async void projects_lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project projectSel = (Project)e.SelectedItem;
            InformationProjectPage informationProject = new InformationProjectPage();
            informationProject.BindingContext = projectSel;
            await Navigation.PushAsync(informationProject);
           // await Navigation.PushAsync(new InformationProjectPage(projects_lv.SelectedItem.ToString()));
        }
    }
}