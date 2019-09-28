using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class PostModel
    {
        public int PostId { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public string PostName { get; set; }

        public int PostClassifyId { get; set; }
    }
}
