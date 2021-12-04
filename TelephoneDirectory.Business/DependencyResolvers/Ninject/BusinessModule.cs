using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Business.Abstract;
using TelephoneDirectory.Business.Concrete;
using TelephoneDirectory.DataAccess.Abstract;
using TelephoneDirectory.DataAccess.Concrete.EntityFramework;

namespace TelephoneDirectory.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IContactService>().To<ContactManager>();
            Bind<IContactDal>().To<EfContactDal>();
        }
    }
}
