using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusMobProj.Models;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProjectPage : ContentPage
    {
        public EditProjectPage()
        {
            InitializeComponent();
        }

        private void btn_cancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void btn_edit_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert("", $"Вы хотите изменить {project.NameProject}?", "Изменить", "Отмена"))
            {
                if (!String.IsNullOrEmpty(project.NameProject))
                {
                    App.ProjectDB.SaveProject(project);
                }
                await this.Navigation.PopAsync();
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (await DisplayAlert( "", $"Вы хотите удалить {project.NameProject}?", "Удалить", "Отмена"))
            {
                App.ProjectDB.DeleteProject(project.ID);
                await Navigation.PushAsync(new SelectProjectPage());
            }
        }
    }
}