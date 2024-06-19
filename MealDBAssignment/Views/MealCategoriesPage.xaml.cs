using MealDBAssignment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MealDBAssignment.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealCategoriesPage : ContentPage
    {
        public MealCategoriesPage()
        {
            InitializeComponent();
            BindingContext = new MealCategoriesViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ((MealCategoriesViewModel)BindingContext).GetMealCategories();

        }
    }
}