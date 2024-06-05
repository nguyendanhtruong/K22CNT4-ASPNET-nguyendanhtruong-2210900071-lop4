using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson6CF.Models
{
    public class NdtBookStore:DbContext

    {
        public NdtBookStore() : base("NdtBookStoreConnectionString") { }
        // khai báo các thuộc tính 
        public DbSet<NdtCategory> NdtCategories { get; set; }
        public DbSet<NdtBook> NdtBooks { get; set; }
    }
}