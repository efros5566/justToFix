using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;

namespace Solid.Service
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _ProductsRepository;

        public ProductsService(IProductsRepository ProductsRepository)
        {
            _ProductsRepository = ProductsRepository;
        }
        public void Delete(int id)
        {
            _ProductsRepository.Delete(id);
        }

        public Products GetById(int id)
        {
            return _ProductsRepository.GetById(id);
        }

        public IEnumerable<Products> GetAll(string? text = "")
        {
            return _ProductsRepository.GetAll(text);
        }

        public void Put(int id, Products product)
        {
            _ProductsRepository.Put(id, product);
        }

        public void Update(Products product)
        {
            _ProductsRepository.Update(product);
        }
    }
}
