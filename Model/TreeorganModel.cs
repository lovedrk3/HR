using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class TreeorganModel
    {
        public int Thid { get; set; }
        [Required(ErrorMessage = "请输入机构名称")]
        public string ThName { get; set; }
        public int Oid { get; set; }

        public int Tid { get; set; }

        public int yesno { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int Sid { get; set; }
    }
}
