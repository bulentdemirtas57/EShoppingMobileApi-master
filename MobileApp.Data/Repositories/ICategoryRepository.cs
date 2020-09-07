using MobileApp.Data.Models;
using System.Collections.Generic;

namespace MobileApp.Data.Repositories
{
    public interface ICategoryRepository
    {
        public IEnumerable<TblCategory> GetCategories();

        public IEnumerable<TblCategory> GetCategoryByParentCategory(int parentCategoryId);

    }
}
