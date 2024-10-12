using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarkerDefinitive.Models
{
    internal interface ICategoriesRepository
    {
        void Add(CategoriesModel categoriesModel);
        void Edit(CategoriesModel categoriesModel);
        void Delete(int id);
        IEnumerable<CategoriesModel> GetAll();
        IEnumerable<CategoriesModel> GetByValue(string value);
    }
}
