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
    
    public partial class ProductProperty
    {
        public int ID { get; set; }
        public int ProductLID { get; set; }
        public int PropertyID { get; set; }
        public string PDID { get; set; }
    
        public virtual ProductL ProductL { get; set; }
        public virtual Property Property { get; set; }
    }
}
