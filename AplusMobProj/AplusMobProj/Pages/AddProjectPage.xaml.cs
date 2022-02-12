using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusMobProj.Models;

namespace AplusMobProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProjectPage : ContentPage
    {
        public AddProjectPage()
        {
            InitializeComponent();
        }

        private void btn_cancel_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private async void btn_add_Clicked(object sender, EventArgs e)
        {
            var project = (Project)BindingContext;
            if (!String.IsNullOrEmpty(project.NameProject))
            {
                await App.ProjectDB.SaveProjectAsync(project);
            }
            await this.Navigation.PopAsync();
        }
    }
}