//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int ID_Orders { get; set; }
        public int ID_Customers { get; set; }
        public int ID_Services { get; set; }
        public decimal Total_Price { get; set; }
        public System.DateTime Time { get; set; }
        public string Delivery_Address { get; set; }
        public string Recipients_Name { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Services Services { get; set; }
    }
}
