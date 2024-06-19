using MealDBAssignment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.Interfaces
{
    public interface IMealsService
    {
        Task<ObservableCollection<Meal>> GetMeals(ObservableCollection<Meal> Meals, string MealType);
    }
}
