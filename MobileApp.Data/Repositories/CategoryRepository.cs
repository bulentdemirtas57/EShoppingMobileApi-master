using MobileApp.Data.Context;
using MobileApp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobileApp.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        MobileAppDbContext _db;

        public CategoryRepository(MobileAppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<TblCategory> GetCategories()
        {
            return _db.TblCategory.Where(p => p.BEnable == 1 && p.ICategoryStatusId == 1 && p.BArchive == 0).OrderBy(p => p.ICategoryRow).ToList();
        }

        public IEnumerable<TblCategory> GetCategoryByParentCategory(int parentCategoryId)
        {
            return _db.TblCategory.Where(p => p.BEnable == 1 && p.ICategoryStatusId == 1 && p.BArchive == 0 && p.ICategoryId == parentCategoryId).OrderBy(p => p.ICategoryRow).ToList();
        }
    }
}
