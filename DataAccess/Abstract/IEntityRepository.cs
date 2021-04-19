using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint - kısıtlama
    //class: reefrans tip olabilir
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir 
    // new() : new lenebilir olmalı (IEntity interface olduğu için newlenemez bu yüzden sadece IEntity implemente eden bir nesne yazılabilir)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // Ürünleri kategoriye , fiyata göre listelemeyi sağlıyor
        List<T> GetAll(Expression<Func< T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //Bu ürünleri kategoriye göre filtrele
        //List<T> GetAllByCategory(int categoryId);

    }
}
