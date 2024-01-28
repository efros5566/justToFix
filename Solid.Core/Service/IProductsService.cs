using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IProductsService
    {
        IEnumerable<Products> GetAll(string? text = "");
        Products GetById(int id);
        void Delete(int id);
        void Put(int id, Products product);
        void Update(Products product);
    }
  
}
