using EFCore.DataAccess.Repositpory.IRepositpry;
using EFCore.Models.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFCore.DataAccess.Repositpory.IRepositpry
{
    public interface IOurModelRepo : IRepository<OurModel>
    {

         void Update(OurModel obj);
    }
}
