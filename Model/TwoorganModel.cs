using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class TwoorganModel
    {
        public int Tid { get; set; }
        [Required(ErrorMessage = "请输入机构名称")]
        public string TName { get; set; }

       
        public int Oid { get; set; }

        [Required(ErrorMessage = "不能为空")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int Sid { get; set; }
    }
}
