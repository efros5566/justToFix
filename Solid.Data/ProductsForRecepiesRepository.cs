using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class ProductsForRecepiesRepository:IProductsForRecepiesRepository
    {
        private readonly DataContext _context;
        public ProductsForRecepiesRepository(DataContext context)
        {
            _context = context;
        }
        public ProductsForRecepies GetById(int id)
        {
            return _context.productsForRecepies.Find(id);
        }
        public List<ProductsForRecepies> GetAll(string? text = "")
        {
            return _context.productsForRecepies.ToList();
        }
        public ProductsForRecepies Update(ProductsForRecepies productsForRecepies)
        {
            _context.productsForRecepies.Add(productsForRecepies);
            _context.SaveChanges();
            return productsForRecepies;
        }

        public ProductsForRecepies Put(int id, ProductsForRecepies productsForRecepies)
        {
            var x = GetById(id);
            x.Amount = productsForRecepies.Amount;
            _context.SaveChanges();
            return x;
        }

        public void Delete(int id)
        {
            var x = GetById(id);
            _context.productsForRecepies.Remove(x);
            _context.SaveChanges();

        }
    }


}
