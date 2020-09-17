using ASP.NET_Core_MVC.Data.Interfaces;
using ASP.NET_Core_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>
              {
                  new Category{categoryName="Electro Cars", description="New kind cars"},
                  new Category{ categoryName="DTI", description="Usual cars"}
              };
            }
        }

    }
}
