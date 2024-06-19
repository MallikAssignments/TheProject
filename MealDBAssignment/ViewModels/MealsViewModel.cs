using MealDBAssignment.Interfaces;
using MealDBAssignment.Models;
using MealDBAssignment.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MealDBAssignment.ViewModels
{
    public class MealsViewModel : INotifyPropertyChanged
    {
        public ICommand ImageTappedCommand { get; set; }
        private ObservableCollection<Meal> _meals;



        public ObservableCollection<Meal> Meals
        {
            get { return _meals; }
            set
            {
                _meals = value;
                OnPropertyChanged(nameof(Meals));
            }
        }
        public MealsViewModel()
        {
            Meals = new ObservableCollection<Meal>();
            ImageTappedCommand = new Command<string>(NavigateToMealDetailsPage);
        }

        public async Task GetMeals(string MealType)
        {
            try
            {
                MealsService mealsService = new MealsService();
                Meals = await mealsService.GetMeals(Meals, MealType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void NavigateToMealDetailsPage(string MealDetailId)
        {
            DependencyService.Get<INavigationService>().NavigateToMealDetailsPage(MealDetailId);
        }
    }
}
