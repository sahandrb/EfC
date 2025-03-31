using EFCore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataAccess.Repositpory.IRepositpry
{
    internal class UnitOfWork
    {
        public AppDbContext _db { get; set; }
        public IOurModelRepo OurModel { get; }

        public UnitOfWork(AppDbContext _db )
        {
            this._db = _db;
            OurModel = new OurModelRepo(_db);
        }
    }
}
