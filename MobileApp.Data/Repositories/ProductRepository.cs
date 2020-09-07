using MobileApp.Data.Context;
using MobileApp.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobileApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        MobileAppDbContext _db;

        public ProductRepository(MobileAppDbContext db)
        {
            _db = db;
        }

        public List<TblProduct> GetAllProducts()
        {
            return _db.TblProduct.Where(p => p.BEnable == 1 && p.BArchive == 0 && p.IProductStatusId == 1).ToList();
        }

        public TblProduct GetProductById(int id)
        {
            return _db.TblProduct.FirstOrDefault(p => p.IProductId == id);
        }

        public List<TblProduct> GetProductsByCategory(int categoryId)
        {
            return _db.TblProduct.Where(p => p.BEnable == 1 && p.BArchive == 0 && p.IProductStatusId == 1 && p.ICategoryId == categoryId).ToList();
        }

        public List<TblProduct> GetProductsByCategoryAndSubCategory(int categoryId, int subCategoryId)
        {
            return _db.TblProduct.Where(p => p.BEnable == 1 && p.BArchive == 0 && p.IProductStatusId == 1 && p.ICategoryId == categoryId && p.ISubCategoryId == subCategoryId).ToList();
        }
    }
}
