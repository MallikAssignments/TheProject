using MealDBAssignment.Models;
using MealDBAssignment.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.ViewModels
{
    public class MealDetailsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MealDetail> _mealdetails;

        public ObservableCollection<MealDetail> MealDetails
        {
            get { return _mealdetails; }
            set
            {
                _mealdetails = value;
                OnPropertyChanged(nameof(MealDetails));
            }
        }

        public MealDetailsViewModel()
        {
            MealDetails = new ObservableCollection<MealDetail>();
        }

        public async Task GetMealDetails(string MealDetailId)
        {
            try
            {
                
                MealDetailsService mealDetailsService = new MealDetailsService();
                MealDetails = await mealDetailsService.GetMealDetails(MealDetails, MealDetailId);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
