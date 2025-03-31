using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataAccess.Repositpory.IRepositpry
{
    public interface IunitOfWork
    {
        //
         IOurModelRepo OurModel { get; }
        public void Save();

    }
}
