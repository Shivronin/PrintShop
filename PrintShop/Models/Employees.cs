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
    
    public partial class Employees
    {
        public int ID_Employees { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int ID_Type { get; set; }
        public int ID_Specialization { get; set; }
        public int ID_Gender { get; set; }
    
        public virtual AccountType AccountType { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Spezialization Spezialization { get; set; }
    }
}
