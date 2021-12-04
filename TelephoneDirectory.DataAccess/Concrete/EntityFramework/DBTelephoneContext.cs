using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Entities.Concrete;

namespace TelephoneDirectory.DataAccess.Concrete.EntityFramework
{
   public class DBTelephoneContext :DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
