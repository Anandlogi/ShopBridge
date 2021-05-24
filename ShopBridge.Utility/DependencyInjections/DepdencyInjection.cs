using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.Utility.DependencyInjections
{
    public static class DepdencyInjection
    {
        public static readonly IKernel NinjectKernel;
        static DepdencyInjection()
        {
            NinjectKernel = new StandardKernel();
            NinjectKernel.Bind<IProductDetail>().To<ProductDetailsConcreat>();
        }
    }
}
