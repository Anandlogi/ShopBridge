using Ninject;
using ShopBridge.Model.ViewModel;
using ShopBridge.Service.Abstraction;
using ShopBridge.Service.DependencyInjections;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ShopBridge.WebAPI.Controllers
{
    [ApiExplorerSettings(IgnoreApi=true)]
    public class ProductDetailController : ApiController
    {
        IProductDetail _ProductDetail;
        [HttpGet]
        [Route("api/product/get")]
        public HttpResponseMessage GetAll()
        {
            _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
            var result = _ProductDetail.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("api/product/Category")]
        public HttpResponseMessage GetByCategory(string value)
        {
            _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
            var result = _ProductDetail.GetByCategory(value);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("api/product/search")]
        public HttpResponseMessage GetBySearch(string value, int pageIndex,int PageSize)
        {
            int recordCount=0;
            _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
            var result = _ProductDetail.GetBySearch(value, pageIndex, PageSize, out recordCount);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("api/product/paging")]
        public HttpResponseMessage GetByCategoryPaging(string value, int pageIndex, int PageSize)
        {
            int recordCount=0;
            _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
            var result = _ProductDetail.GetByCategoryPaging(value, pageIndex, PageSize, out recordCount);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("api/product/save")]
        [Route("api/product/Update")]
        public HttpResponseMessage Save(ProductDetailModel Model)
        {
            if (ModelState.IsValid)
            {
                _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
                _ProductDetail.SaveProduct(Model);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Validation Failed");
        }

        [HttpDelete]
        [Route("api/product/delete/{productId}")]
        public HttpResponseMessage Delete(int productId)
        {
            
            _ProductDetail = DepdencyInjection.NinjectKernel.Get<IProductDetail>();
            _ProductDetail.deleteProduct(productId);
            return Request.CreateResponse(HttpStatusCode.OK, "Data removed");
        }
    }
}
