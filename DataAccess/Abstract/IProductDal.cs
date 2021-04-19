using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //IEntityRepository i Product için yapılandırma anlamına gelir
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
