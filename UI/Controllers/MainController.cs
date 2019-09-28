using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using IOC;
using Model;
using UI.Filters;
namespace UI.Controllers
{
    
    public class MainController : Controller
    {
        IUsersBLL ub = IocCreate.CreateUsersBLL();
        // GET: Main
        [Login]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult top()
        {
            return View();
        }
        public ActionResult left()
        {
            return View();
        }
        public ActionResult main()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string uName,string uPwd)
        {
            List<UsersModel> list = ub.Login(uName,uPwd);
            if (list.Count>0)
            {
                foreach (UsersModel item in list)
                {
                    Session["uName"] = item.uName;
                }
                return Content("<script>alert('登录成功');window.location.href='Index'</script>");
            }
            return View();
        }
    }
}