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
    public class MealDetailsService : IMealDetailsService
    {
        private readonly IHTTPClient<MealDetails> _httpclient;
        public MealDetailsService()
        {
            _httpclient = App.Container.Resolve<IHTTPClient<MealDetails>>();
        }

        public async Task<ObservableCollection<MealDetail>> GetMealDetails(ObservableCollection<MealDetail> MealDetails, string MealDetailId)
        {
            try
            {
                string url = GenerateURL.GenerateDetailMealsURL(MealDetailId);
                var data = await _httpclient.GetResponseFromAPI(url);

                foreach (var mealDetails in data.Meals)
                {
                    MealDetails.Add(mealDetails);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return MealDetails;
        }
    }
}
