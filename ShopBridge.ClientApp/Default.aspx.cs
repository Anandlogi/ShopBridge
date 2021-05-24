using Newtonsoft.Json;
using ShopBridge.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopBridge.ClientApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            GetAllProduct();
        }

        public async Task<List<ProductDetailModel>> GetAllProduct()
        {
            using (var httpClient = new HttpClient())
            using (var httpResonse = await httpClient.GetAsync("http://localhost:53674/api/product/get").ConfigureAwait(false))
            {
                return JsonConvert.DeserializeObject<List<ProductDetailModel>>(await httpResonse.Content.ReadAsStringAsync().ConfigureAwait(false));
            }

            //HttpResponseMessage response = new HttpResponseMessage();

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var task =
            //    await
            //        // ReSharper disable once UseStringInterpolation
            //        client.GetAsync("http://localhost:53674/api/product/get").ConfigureAwait(false);

            //task.EnsureSuccessStatusCode();

            //var payload = task.Content.ReadAsStringAsync();

            //return JsonConvert.DeserializeObject<List<ProductDetailModel>>(await payload.ConfigureAwait(false));

            //List<ProductDetailModel> resultList = new List<ProductDetailModel>();
            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = new HttpResponseMessage();

            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //response = client.GetAsync("http://localhost:53674/api/product/get").Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var result = response.Content.ReadAsStringAsync().Result;

            //    resultList= JsonConvert.DeserializeObject<List<ProductDetailModel>>(result);
            //}

            //return resultList;



        }
    }
}