//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Real_estate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deals
    {
        public long Id { get; set; }
        public Nullable<long> Demand_Id { get; set; }
        public Nullable<long> Supply_Id { get; set; }
    
        public virtual Demands Demands { get; set; }
        public virtual Supplies Supplies { get; set; }
    }
}
