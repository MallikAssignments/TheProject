using MealDBAssignment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.Interfaces
{
    public interface IMealDetailsService
    {
        Task<ObservableCollection<MealDetail>> GetMealDetails(ObservableCollection<MealDetail> MealDetails, string MealDetailId);
    }
}
