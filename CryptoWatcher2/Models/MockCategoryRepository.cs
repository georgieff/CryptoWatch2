using System;
using System.Collections.Generic;

namespace CryptoWatcher2.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories 
        {
            get 
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Fruit pies" },
                    new Category{CategoryId=2, CategoryName="Cheese cakes" },
                    new Category{CategoryId=3, CategoryName="Seasonal pies" }
                };
            }
        }
    }
}
