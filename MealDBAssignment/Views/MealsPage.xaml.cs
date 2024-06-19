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
    public partial class MealsPage : ContentPage
    {
        string CatName;
        public MealsPage(string _catname)
        {
            InitializeComponent();
            BindingContext = new MealsViewModel();
            this.CatName = _catname;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ((MealsViewModel)BindingContext).GetMeals(CatName);

        }


    }
}