using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.Enums;

namespace VegetableStore.Models.ViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Vui lòng điền tiêu đề", AllowEmptyStrings = false)]
        public string Title { get; set; }
        public int Vote { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

      //  [Required(ErrorMessage = "Vui lòng điền nội dung", AllowEmptyStrings = false)]
        public string Content { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }
    }
}
