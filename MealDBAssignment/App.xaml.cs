using Autofac;
using MealDBAssignment.HTTPClient;
using MealDBAssignment.Interfaces;
using MealDBAssignment.Services;
using MealDBAssignment.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealDBAssignment
{
    public partial class App : Application
    {
        public static Autofac.IContainer Container { get; private set; }

        public App()
        {
            InitializeComponent();


            DependencyService.Register<INavigationService, NavigationService>();

            var builder = new ContainerBuilder();
            builder.RegisterGeneric(typeof(GetHTTPResponse<>)).As(typeof(IHTTPClient<>));
            Container = builder.Build();

            MainPage = new NavigationPage(new MealCategoriesPage());
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
