using ShopBridge.Model.ViewModel;
using ShopBridge.Repository.DatabaseContext;
using ShopBridge.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Service.Concreat
{
    class ProductDetailsConcreat : IProductDetail
    {
        public void deleteProduct(int ProductId)
        {
            using (var dbConetex = new ShopBridgeEntities())
            {

                var remove = (from aremove in dbConetex.ProductsCategoryMappings
                              where aremove.ProductId == ProductId
                              select aremove).ToList();


                foreach (var re in remove)
                {
                    dbConetex.ProductsCategoryMappings.Remove(re);
                    dbConetex.SaveChanges();
                }


                var ResultProduct = (from aremove in dbConetex.ProductDetails
                                     where aremove.ProductId == ProductId
                                     select aremove).ToList();


                foreach (var re in ResultProduct)
                {
                    dbConetex.ProductDetails.Remove(re);
                    dbConetex.SaveChanges();
                }


            }
        }

        public List<ProductDetailModel> GetAll()
        {
            List<ProductDetailModel> Result = null;
            try
            {
                using (var dbConetex = new ShopBridgeEntities())
                {
                    var ResultList = dbConetex.ProductDetails.ToList(); //dbConetex.ProductDetails.ToList();
                    if (ResultList != null)
                        Result = AutoMapper.Mapper.Map<List<ProductDetail>, List<ProductDetailModel>>(ResultList);
                }
            }
            catch (Exception ex)
            {
            }
            return Result;
        }

        public List<ProductDetailModel> GetByCategory(string Category)
        {
            List<ProductDetailModel> Result = null;
            try
            {
                using (var dbConetex = new ShopBridgeEntities())
                {
                    var ResultList = (from pd in dbConetex.ProductDetails
                                      join mp in dbConetex.ProductsCategoryMappings on pd.ProductId equals mp.ProductId
                                      join ct in dbConetex.ProductCategories on mp.CategoryId equals ct.CategoryId
                                      where ct.CategoryName == Category
                                      select pd).ToList();
                    if (ResultList != null)
                        Result = AutoMapper.Mapper.Map<List<ProductDetail>, List<ProductDetailModel>>(ResultList);
                }
            }
            catch (Exception ex)
            {
            }
            return Result;
        }

        public List<ProductDetailModel> GetByCategoryPaging(string searchKey, int pageIndex, int PageSize, out int recordCount)
        {
            recordCount = 0;
            List<ProductDetailModel> result = new List<ProductDetailModel>();
            using (var dbConetex = new ShopBridgeEntities())
            {
                ObjectParameter returnId = new ObjectParameter("RecordCount", typeof(int));
                var ResultList = dbConetex.GetProductsCategoryWise1(searchKey, pageIndex, PageSize, returnId).ToList();
                if (ResultList != null)
                    result = AutoMapper.Mapper.Map<List<ProductDetail>, List<ProductDetailModel>>(ResultList);
            }
            return result;
        }

        public List<ProductDetailModel> GetBySearch(string searchKey, int pageIndex, int PageSize, out int recordCount)
        {
            recordCount = 0;
            List<ProductDetailModel> result = new List<ProductDetailModel>();
            using (var dbConetex = new ShopBridgeEntities())
            {

                var ResultList = dbConetex.GetProductsSearchWise1(searchKey, pageIndex, PageSize).ToList();
                if (ResultList != null)
                    result = AutoMapper.Mapper.Map<List<ProductDetail>, List<ProductDetailModel>>(ResultList);
            }
            return result;
        }

        public void SaveProduct(ProductDetailModel model)
        {
            using (var dbConetex = new ShopBridgeEntities())
            {
                dbConetex.SaveProduct(model.ProductName,model.ProductPrice,model.ProductOldPrice,model.ProductAvailableQTY,model.SplOffer,model.ProductDesc, model.ProductCode,model.ProductCategory, model.ProductId);
            }
        }

       
    }
}
