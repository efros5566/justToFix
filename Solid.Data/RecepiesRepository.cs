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
    public class RecepiesRepository:IRecepiesRepository
    {
        private readonly DataContext _context;
        public RecepiesRepository(DataContext context)
        {
            _context = context;
        }
        public Recepies GetById(int id)
        {
            return _context.recepies.Find(id);
        }
        public IEnumerable<Recepies> GetAll(string? text = "")
        {
            return _context.recepies.Include(u=>u.ProductsList);
        }
        public Recepies Update(Recepies Recepies)
        {
            _context.recepies.Add(Recepies);
            _context.SaveChanges();
            return Recepies;
        }

        public Recepies Put(int id, Recepies recepies)
        {
            var x = GetById(id);
            x.Name = recepies.Name;
            _context.SaveChanges();
            return x;
        }

        public void Delete(int id)
        {
            var x = GetById(id);
            _context.recepies.Remove(x);
            _context.SaveChanges();

        }
    }
}
