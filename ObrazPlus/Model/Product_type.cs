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
    
    public partial class Product_type
    {
        public Product_type()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Koefficient { get; set; }
    
        public virtual ICollection<Products> Products { get; set; }
    }
}
