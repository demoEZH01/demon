//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObrazPlus.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material_products
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int ProductId { get; set; }
        public decimal RequiredQuantity { get; set; }
    
        public virtual Materials Materials { get; set; }
        public virtual Products Products { get; set; }
    }
}
