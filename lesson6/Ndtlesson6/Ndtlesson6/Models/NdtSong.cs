using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ndtlesson6.Models
{
    public class NdtSong
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="hãy nhập tên tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string NdtTitle { get; set; }
        [Required(ErrorMessage ="tên các giả ")]
        [DisplayName("Tên Tác giả ")]


        public string NdtAuthor { get; set; }
        [Required(ErrorMessage ="tên nghệ sĩ ")]
        [DisplayName("Nghệ sĩ")]

        public string NdtArlist { get; set; }
        [Required(ErrorMessage =" năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Ndt: nhập năm xuất bản 2 kí tự số ")]
        [Range(1900,2024,ErrorMessage =" nhập giới hạn từ 1900-2024")]
        [DisplayName("Năm")]

        public int NdtYearRelease { get; set; }


    }
}