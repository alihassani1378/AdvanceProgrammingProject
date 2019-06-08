using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvaceProject.BackEnd
{
    public class UnitOfWork:IDisposable
    {
        Store_DBEntities db = new Store_DBEntities();


        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
