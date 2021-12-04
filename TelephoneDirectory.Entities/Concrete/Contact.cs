using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Entities.Abstract;

namespace TelephoneDirectory.Entities.Concrete
{
    public class Contact :IEntity
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}
