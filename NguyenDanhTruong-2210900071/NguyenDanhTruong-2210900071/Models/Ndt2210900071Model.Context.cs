﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenDanhTruong_2210900071.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Nguyễn_Danh_Trường__2210900071Entities : DbContext
    {
        public Nguyễn_Danh_Trường__2210900071Entities()
            : base("name=Nguyễn_Danh_Trường__2210900071Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NDT_SACH> NDT_SACH { get; set; }
        public virtual DbSet<NDT_TACGIA> NDT_TACGIA { get; set; }
    }
}