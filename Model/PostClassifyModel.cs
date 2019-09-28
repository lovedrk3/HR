using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PostClassifyModel
    {
        public int PostClassifyId { get; set; }
        [Required(ErrorMessage = "职业分类不能为空")]
        [StringLength(4, ErrorMessage = "名字不能超过4位")]
        public string PostClassifyName { get; set; }
    }
}
