﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NdtK22CNT4Lesson11_2210900071.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NdtCategory
    {
        [Display(Name ="mã danh mục")]
        public int NdtID { get; set; }
        [Display(Name = "tên danh mục")]
        public string NdtCateName { get; set; }
        [Display(Name = "trạng thái")]
        public Nullable<bool> NdtStatus { get; set; }
    }
}