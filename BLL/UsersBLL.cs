using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IBLL;
using IDAO;
using DAO;
using IOC;
namespace BLL
{
    public class UsersBLL : IUsersBLL
    {
        IUsersDAO ud = IocCreate.CreateUsersDAL();
        public List<UsersModel> Login(string uName, string uPwd)
        {
            return ud.Login(uName,uPwd);
        }
    }
}
