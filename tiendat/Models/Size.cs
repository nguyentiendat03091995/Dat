//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tiendat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size
    {
        public Size()
        {
            this.ProductDetails = new HashSet<ProductDetail>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
