namespace MobileApp.Models
{
    public class ProductByCategoryRequestModel
    {
        public int CategoryId { get; set; }
    }

    public class ProductByCategoryAndSubCategoryRequestModel
    {
        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }
    }
}
