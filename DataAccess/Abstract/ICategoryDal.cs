using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    { 
        //void Add(Category product);        //ıentityrepository eklediğimiz için bunlara da gerek kalmıyor 
        //void Update(Category product);
        //void Delete(Category product);
        List<Category> GetAllByCategory(int categoryId);//ürünleri kategoriye göre filtrele
    }
}
