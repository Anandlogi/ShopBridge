using ShopBridge.Model.ViewModel;
using ShopBridge.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Utility.AutoMapper
{
    public class AutoMapperProfiles
    {
        public static void Configure()
        {
            AutoMapper.Mapper.CreateMap<ProductDetail, ProductDetailModel>();
        }
    }
}
