using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IProductsForRecepiesRepository
    {
        List<ProductsForRecepies> GetAll(string? text = "");
        ProductsForRecepies GetById(int id);
        ProductsForRecepies Update(ProductsForRecepies ProductsForRecepies);
        ProductsForRecepies Put(int id, ProductsForRecepies ProductsForRecepies);
        void Delete(int id);

    }
}
