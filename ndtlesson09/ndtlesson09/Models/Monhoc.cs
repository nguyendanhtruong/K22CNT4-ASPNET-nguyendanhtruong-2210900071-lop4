//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ndtlesson09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monhoc()
        {
            this.ketquas = new HashSet<ketqua>();
        }
    
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> SoTiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ketqua> ketquas { get; set; }
    }
}