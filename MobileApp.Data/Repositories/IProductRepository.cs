using MobileApp.Data.Models;
using System.Collections.Generic;

namespace MobileApp.Data.Repositories
{
    public interface IProductRepository
    {
        TblProduct GetProductById(int id);

        List<TblProduct> GetAllProducts();

        List<TblProduct> GetProductsByCategory(int categoryId);

        List<TblProduct> GetProductsByCategoryAndSubCategory(int categoryId, int subCategoryId);
    }
}
