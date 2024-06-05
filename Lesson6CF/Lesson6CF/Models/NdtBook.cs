using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson6CF.Models
{
    public class NdtBook
    {
        [Key]
        public int NdtId { get; set; }
        public string NdtBookId { get; set; }
        public string NdtTitle { get; set; }
        public string NdtAuthor { get; set; }
        public int NdtYear { get; set; }
        public string NdtPulisher { get; set; }
        public string NdtPicture { get; set; }
        public int NDTCategoryId { get; set; }
        //thuộc tính quan hệ 
        public virtual NdtCategory NdtCategory { get; set; }

    }
}