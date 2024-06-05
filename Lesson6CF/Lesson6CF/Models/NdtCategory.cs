using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson6CF.Models
{
    public class NdtCategory
    {
        [Key]
        public int NdtId { get; set; }
        public string NdtCategoryName { get; set; }
        //thuộc tính quan hệ 
        public virtual ICollection<NdtBook> NdtBooks { get; set; }

    }
}