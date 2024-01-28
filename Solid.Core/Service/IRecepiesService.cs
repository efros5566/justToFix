using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IRecepiesService
    {
        IEnumerable<Recepies> GetAll(string? text = "");
        Recepies GetById(int id);
        void Delete(int id);
        void Put(int id, Recepies product);
        void Update( Recepies product);
    }
}
