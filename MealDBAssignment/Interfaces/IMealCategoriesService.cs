using MealDBAssignment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.Interfaces
{
    public interface IMealCategoriesService
    {
        Task<ObservableCollection<MealCategory>> GetMealCategories(ObservableCollection<MealCategory> MealCategories);
    }
}
