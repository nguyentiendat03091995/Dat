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
    
    public partial class CategoryL
    {
        public CategoryL()
        {
            this.CategoryProperties = new HashSet<CategoryProperty>();
        }
    
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string H1 { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Filter { get; set; }
        public int Language { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<CategoryProperty> CategoryProperties { get; set; }
    }
}
