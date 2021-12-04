using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.DataAccess.Abstract;
using TelephoneDirectory.Entities.Concrete;

namespace TelephoneDirectory.DataAccess.Concrete.EntityFramework
{
    public class EfContactDal : EfEntityRepositoryBase<Contact, DBTelephoneContext>,IContactDal
    {
        
    }
}
