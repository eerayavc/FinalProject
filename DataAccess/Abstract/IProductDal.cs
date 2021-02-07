using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //operasyonlar
    //interface nin kendisi değil operasyonları public
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
