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
    public class MealCategoriesViewModel : INotifyPropertyChanged
    {
        public ICommand ImageTappedCommand { get; set; }
        private ObservableCollection<MealCategory> _mealcategories;
        public ObservableCollection<MealCategory> MealCategories
        {
            get { return _mealcategories; }
            set
            {
                _mealcategories = value;
                OnPropertyChanged(nameof(MealCategories));
            }
        }

        public MealCategoriesViewModel()
        {
            MealCategories = new ObservableCollection<MealCategory>();
            ImageTappedCommand = new Command<string>(NavigateToMealsPage);
        }

        public async Task GetMealCategories()
        {
            try
            {

                MealCategoriesService mealCategoriesService = new MealCategoriesService();
                MealCategories = await mealCategoriesService.GetMealCategories(MealCategories);
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

        private void NavigateToMealsPage(string CatName)
        {
            DependencyService.Get<INavigationService>().NavigateToMealsPage(CatName);
        }

    }
}
