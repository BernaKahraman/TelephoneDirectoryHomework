using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TelephoneDirectory.Entities.Abstract;
using TelephoneDirectory.Entities.Concrete;

namespace TelephoneDirectory.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class , IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //kullanıcı filtreyi boş verebilir.zorunluluğu yok
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //void Delete(Contact contact); // t adında bir generic ifade tanımlıyorum. Çünkü buraya yazdığımız değişkenlik gösterebilir
        //bugün contact olan başka bir gün product olabilir o nedenle nesnel bir ifade veriyoruz.

    }
}
