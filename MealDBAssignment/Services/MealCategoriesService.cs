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
    public class MealCategoriesService : IMealCategoriesService
    {

        private readonly IHTTPClient<MealCategories> _httpclient;
        public MealCategoriesService()
        {
            _httpclient = App.Container.Resolve<IHTTPClient<MealCategories>>();

        }

        public async Task<ObservableCollection<MealCategory>> GetMealCategories(ObservableCollection<MealCategory> MealCategories)
        {
            try
            {
                string url = GenerateURL.GenerateMealCategoriesURL();
                var data = await _httpclient.GetResponseFromAPI(url);

                foreach (var category in data.Categories)
                {
                    MealCategories.Add(category);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return MealCategories;
        }


    }
}
