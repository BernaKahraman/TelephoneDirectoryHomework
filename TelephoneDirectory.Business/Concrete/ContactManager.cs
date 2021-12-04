using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Business.Abstract;
using TelephoneDirectory.DataAccess.Abstract;
using TelephoneDirectory.DataAccess.Concrete;
using TelephoneDirectory.DataAccess.Concrete.EntityFramework;
using TelephoneDirectory.Entities.Concrete;

namespace TelephoneDirectory.Business.Concrete
{
   public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal) 
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
