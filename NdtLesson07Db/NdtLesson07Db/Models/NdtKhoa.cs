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
    
    public partial class NdtKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NdtKhoa()
        {
            this.NdtSinhViens = new HashSet<NdtSinhVien>();
        }
    
        public string NdtMaKH { get; set; }
        public string NdtTenKH { get; set; }
        public Nullable<bool> NdtTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NdtSinhVien> NdtSinhViens { get; set; }
    }
}