using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class AttributeNameModel
    {
        public int ANID { get; set; }
        [Required(ErrorMessage ="请输入属性名称")]
        public string ANName { get; set; }
        public int ATID { get; set; }
        public string ATName { get; set; }
    }
}
