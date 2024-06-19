using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MealDBAssignment.Interfaces
{
    public interface IHTTPClient<T>
    {
        Task<T> GetResponseFromAPI(string URLString);
    }
}
