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
    public class RecepiesService : IRecepiesService
    {
        private readonly IRecepiesRepository _Recepies;

        public RecepiesService(IRecepiesRepository RecepiesRepository)
        {
            _Recepies= RecepiesRepository;
        }
        public void Delete(int id)
        {
            _Recepies.Delete(id);
        }

        public Recepies GetById(int id)
        {
            return _Recepies.GetById(id);
        }

        public IEnumerable<Recepies> GetAll(string? text = "")
        {
            return _Recepies.GetAll(text);
        }

        public void Put(int id, Recepies product)
        {
            _Recepies.Put(id, product);
        }

        public void Update(Recepies product)
        {
            _Recepies.Update(product);
        }
    }
}
