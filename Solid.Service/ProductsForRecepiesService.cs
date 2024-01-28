using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ProductsForRecepiesService : IProductsForRecepiesService
    {
        private readonly IProductsForRecepiesRepository _ProductsForRecepiesRepository;

        public ProductsForRecepiesService(IProductsForRecepiesRepository ProductsForRecepiesRepository)
        {
            _ProductsForRecepiesRepository = ProductsForRecepiesRepository;
        }
        public void Delete(int id)
        {
            _ProductsForRecepiesRepository.Delete(id);
        }

        public ProductsForRecepies GetById(int id)
        {
            return _ProductsForRecepiesRepository.GetById(id); 
        }

        public List<ProductsForRecepies> GetAll(string? text = "")
        {
            return _ProductsForRecepiesRepository.GetAll(text);
        }

        public void Put(int id, ProductsForRecepies product)
        {
            _ProductsForRecepiesRepository.Put(id, product);
        }

        public void Update( ProductsForRecepies product)
        {
            _ProductsForRecepiesRepository.Update(product);
        }
    }
}
