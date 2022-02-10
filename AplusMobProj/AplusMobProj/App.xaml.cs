using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusMobProj.Data;
using System.IO;
[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "ProjectFont")]
namespace AplusMobProj
{
    public partial class App : Application
    {
        static ProjectDB projectDB;
        public static ProjectDB ProjectDB
        {
            get
            {
                if (projectDB == null)
                {
                    projectDB = new ProjectDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjecttsDatabase.db3"));
                }
                return projectDB;
            }
            
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.AuthorizationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
