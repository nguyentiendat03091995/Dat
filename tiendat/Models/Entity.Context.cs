﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ibebizEntities1 : DbContext
    {
        public ibebizEntities1()
            : base("name=ibebizEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryL> CategoryLs { get; set; }
        public virtual DbSet<CategoryProperty> CategoryProperties { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<FCategory> FCategories { get; set; }
        public virtual DbSet<FCategoryL> FCategoryLs { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsL> NewsLs { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PriceChart> PriceCharts { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductL> ProductLs { get; set; }
        public virtual DbSet<ProductProperty> ProductProperties { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyDetail> PropertyDetails { get; set; }
        public virtual DbSet<Script> Scripts { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<SliderL> SliderLs { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
    }
}
