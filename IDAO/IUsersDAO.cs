using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
    public interface IUsersDAO
    {
        List<UsersModel> Login(string uName,string uPwd);
    }
}
