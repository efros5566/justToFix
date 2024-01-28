using Microsoft.EntityFrameworkCore;
using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class ProductRepository: IProductsRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public Products GetById(int id)
        {
            return _context.products.Find(id);
        }
        public IEnumerable<Products> GetAll(string? text="")
        {
            return _context.products;
        }
        public Products Update(Products products)
        {
           _context.products.Add(products);
            _context.SaveChanges();
            return products;
        }

        public Products Put(int id, Products products)
        {
            var x = GetById(id);
            x.Name=products.Name;
            _context.SaveChanges();
            return x;
        }

        public void Delete(int id)
        {
            var x = GetById(id);
            _context.products.Remove(x);
            _context.SaveChanges();
            
        }
    }
}
