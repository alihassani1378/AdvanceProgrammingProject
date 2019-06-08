using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvaceProject.BackEnd
{
    public class UnitOfWork:IDisposable
    {
        Store_DBEntities1 db = new Store_DBEntities1();


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
