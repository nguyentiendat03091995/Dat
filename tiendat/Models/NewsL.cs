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
    
    public partial class NewsL
    {
        public int ID { get; set; }
        public int NewsID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Language { get; set; }
    
        public virtual News News { get; set; }
    }
}