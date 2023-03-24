using EBookStoreCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EBookStoreCore.Data
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {

        Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T, object>>[] includeProperties );
        // var deger=repository.GetAsyc(k=>k.Id==15) dediğimizde o değeri getirecek
        //diğeri ise kullanıcı yada alacağımız değerin birden fazla parametresini çağırabileceğiz örneğin id=10 olan kullanıcıyı getirirken yapmışolduğu harcamaları da getirebiliriz
        //var kullanıcı=repository.GetAsync(m=>m.Id=10,m=>m.Satis,m=>m.Fatura) gibii
        Task<T> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> AnyAsyc(Expression<Func<T, bool>> predicate);//örneğin kayıt olacak kullanıcı,kategori var mı kotroll et
                                                                //var deger=_cateogori_repository.Any(x=>x.Category.Name=="Roman")
       Task<bool> CountAsync(Expression<Func<T, bool>> predicate);// var categorisayi=_categorirepo.Count() //tüm kategorilerin sayısı
                                                                  //var roman=_cateorirepo.Count(x=>x.Cateori.Name=="roman")
    }

}
