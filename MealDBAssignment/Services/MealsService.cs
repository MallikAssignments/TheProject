using Autofac;
using MealDBAssignment.Helpers;
using MealDBAssignment.Interfaces;
using MealDBAssignment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.Services
{
    public class MealsService : IMealsService
    {
        private readonly IHTTPClient<Meals> _httpclient;
        public MealsService()
        {
            _httpclient = App.Container.Resolve<IHTTPClient<Meals>>();
        }
        public async Task<ObservableCollection<Meal>> GetMeals(ObservableCollection<Meal> Meals, string MealType)
        {
            try
            {
                string url = GenerateURL.GenerateMealsURL(MealType);
                var data = await _httpclient.GetResponseFromAPI(url);

                foreach (var meal in data.meals)
                {
                    Meals.Add(meal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Meals;
        }
    }
}
