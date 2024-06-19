using MealDBAssignment.Interfaces;
using MealDBAssignment.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MealDBAssignment.Services
{
    public class NavigationService : INavigationService
    {
        public void NavigateToMealsPage(string CatName)
        {
            Application.Current.MainPage.Navigation.PushAsync(new MealsPage(CatName));
        }

        public void NavigateToMealDetailsPage(string MealDetailId)
        {
            Application.Current.MainPage.Navigation.PushAsync(new MealDetailsPage(MealDetailId));
        }
    }
}
