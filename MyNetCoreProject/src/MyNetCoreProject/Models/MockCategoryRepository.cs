using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNetCoreProject.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId = 1, CategoryName = "Fruit Pie", Description="All Fruit Pies" },
                    new Category{CategoryId = 2, CategoryName = "Cheese cakes", Description="All Cheese Cakes" },
                    new Category{CategoryId = 3, CategoryName = "Seasonal pies", Description="All Seaonal Pies" }
                };
            }
        }
    }
}
