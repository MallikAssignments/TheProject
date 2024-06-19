using System;
using System.Collections.Generic;
using System.Text;

namespace MealDBAssignment.Interfaces
{
    public interface INavigationService
    {
        void NavigateToMealsPage(string CatName);
        void NavigateToMealDetailsPage(string MealDetailId);
    }
}
