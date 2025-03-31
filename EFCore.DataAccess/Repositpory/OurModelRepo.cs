using EFCore.DataAccess.Data;
using EFCore.DataAccess.Repositpory.IRepositpry;
using EFCore.Models.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DataAccess.Repositpory
{
    public class OurModelRepo  : Repository<OurModel> , IOurModelRepo  
    {
        public AppDbContext _db { get; set; }

        public OurModelRepo(AppDbContext _db) : base(_db)
        {
            this._db = _db;

        }
        public void Update(OurModel obj)
        {
            _db.OurMM.Update(obj);
        }
    }
}
