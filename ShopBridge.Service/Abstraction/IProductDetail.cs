using ShopBridge.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Service.Abstraction
{
    public interface IProductDetail
    {
        List<ProductDetailModel> GetAll();
        List<ProductDetailModel> GetByCategory(string Category);

        void SaveProduct(ProductDetailModel model);
      
        void deleteProduct(int ProductId);

        List<ProductDetailModel> GetBySearch(string searchKey, int pageIndex, int PageSize, out int recordCount);

        List<ProductDetailModel> GetByCategoryPaging(string searchKey, int pageIndex, int PageSize, out int recordCount);
    }
}
