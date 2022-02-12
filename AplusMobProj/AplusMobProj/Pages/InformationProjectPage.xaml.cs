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
    public partial class InformationProjectPage : TabbedPage
    {
        public InformationProjectPage(string projName)
        {
            InitializeComponent();
            lbl_namepr.Text = projName;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.EditProjectPage());
        }
    }
}