using System;
using System.Text;

namespace MealDBAssignment.Helpers
{
    public static class GenerateURL
    {
        public static string GenerateMealCategoriesURL()
        {
            return string.Format(URLConstants.MEALCATEGORIES);
        }
        public static string GenerateMealsURL(string MealType)
        {
            return string.Format(URLConstants.MEALS, MealType);
        }

        public static string GenerateDetailMealsURL(string MealDetailId)
        {
            return string.Format(URLConstants.DETAILMEALS, MealDetailId);
        }
    }
}
