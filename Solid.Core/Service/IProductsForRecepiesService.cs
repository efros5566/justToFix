using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IProductsForRecepiesService
    {
        List<ProductsForRecepies> GetAll(string? text = "");
        ProductsForRecepies GetById(int id);
        void Delete(int id);
        void Put(int id, ProductsForRecepies product);
        void Update(ProductsForRecepies product);
    }
}
