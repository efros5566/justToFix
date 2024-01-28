using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAll(string? text="");
        Products GetById(int id);
        Products Update(Products products);
        Products Put(int id, Products products);
        void Delete (int id);


    }
}
