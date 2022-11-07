using CarShop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarShop.Data.Models;

namespace CarShop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Електромобілі", desc = "Автомобілі які працюють використовуючи електроенергію" },
                    new Category{categoryName = "Автомобілі з ДВЗ", desc = "Автомобілі які працюють використовуючи двигуни внутрішнього згорання" }
                };
            }
        }
    }
}