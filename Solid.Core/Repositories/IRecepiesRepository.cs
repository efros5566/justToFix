using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IRecepiesRepository
    {
        IEnumerable<Recepies> GetAll(string? text = "");
        Recepies GetById(int id);
        Recepies Update(Recepies Recepies);
        Recepies Put(int id, Recepies Recepies);
        void Delete(int id);

    }
}
