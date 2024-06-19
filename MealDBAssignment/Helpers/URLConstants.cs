using System;
using System.Text;

namespace MealDBAssignment.Helpers
{
    public class URLConstants
    {
        public const string MEALCATEGORIES = "https://www.themealdb.com/api/json/v1/1/categories.php";
        public const string MEALS = "https://www.themealdb.com/api/json/v1/1/filter.php?c={0}";
        public const string DETAILMEALS = "https://www.themealdb.com/api/json/v1/1/lookup.php?i={0}";
    }
}
