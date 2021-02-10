using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public yaptığımız zaman bu classa diğer katmanlarda ulaşabilsin demek.
    //internal class demek sadece entities erişebilir demek.Classın defaultu odur.
    public class Product :IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
