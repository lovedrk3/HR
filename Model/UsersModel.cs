using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class UsersModel
    {
        
        public int uID { get; set; }
        [Required(ErrorMessage = "用户名不能为空")]
        public string uName { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string uPwd { get; set; }
    }
}
