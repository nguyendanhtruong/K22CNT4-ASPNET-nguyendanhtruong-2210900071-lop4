//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NdtLesson07Db.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NdtSinhVien
    {
        public string NdtMaSv { get; set; }
        public string NdtHoSv { get; set; }
        public string NdtTenSv { get; set; }
        public Nullable<System.DateTime> NdtNgaySinh { get; set; }
        public Nullable<bool> NdtPhai { get; set; }
        public string NdtPhone { get; set; }
        public string NdtEmail { get; set; }
        public string NdtMaKH { get; set; }
    
        public virtual NdtKhoa NdtKhoa { get; set; }
    }
}
