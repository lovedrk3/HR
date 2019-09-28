using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class OneorganModel
    {
        public int Oid { get; set; }
        [Required(ErrorMessage = "请输入机构名称")]
        public string OName { get; set; }
        [Required(ErrorMessage = "不能为空")]
        public int Pid { get; set; }
        [Required(ErrorMessage = "不能为空")]

        public int SID { get; set; }
    }
}
