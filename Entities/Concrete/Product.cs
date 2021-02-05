using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public yaptığmız zaman diğer katmanlarda bu clasa ulaşabilir.dataacces ürünü eklicek,business kontrol edecek,console bunu gösterecek
    //bir clasın defaultu internal dır.internala sadece entities erişebilir.
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }//stok adedi
        public decimal UnitPrice { get; set; }//birim fiyatı
    }
}
