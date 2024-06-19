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
    public partial class MealDetailsPage : ContentPage
    {
        string MealDetailId;
        public MealDetailsPage(string _mealdetailid)
        {
            InitializeComponent();
            BindingContext = new MealDetailsViewModel();
            this.MealDetailId = _mealdetailid;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ((MealDetailsViewModel)BindingContext).GetMealDetails(MealDetailId);
        }
    }
}