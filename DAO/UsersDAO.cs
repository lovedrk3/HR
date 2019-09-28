using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EFEntity;

namespace DAO
{
    public class UsersDAO :DaoBase<Users>, IUsersDAO
    {
        public List<UsersModel> Login(string uName, string uPwd)
        {
            MyDbContext db = new MyDbContext();
            List<Users> list = db.Users.AsNoTracking().Where(e=>e.uName==uName&&e.uPwd==uPwd).Select(e=>e).ToList();
            List<UsersModel> list2 = new List<UsersModel>();
            foreach (Users item in list)
            {
                UsersModel um = new UsersModel() { uID = item.uID, uName = item.uName,uPwd=item.uPwd };
                list2.Add(um);
            }
            return list2;
        }
    }
}
