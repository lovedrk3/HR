using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using IBLL;
using IOC;
using Newtonsoft.Json;
namespace UI.Controllers
{
    public class ProfessionController : Controller
    {
        IPostBLL ipb = IocCreate.CreatePostBLL();
        IAttributeTypeBLL iat = IocCreate.CreateAttributeTypeBLL();
        // GET: Profession
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return Content(JsonConvert.SerializeObject(ipb.ProfessionSelect()));
        }
        public ActionResult Del(int id)
        {
            AttributeNameModel an = new AttributeNameModel() { ANID = id };
            if (iat.AttributeNameDelete(an) > 0)
            {
                return Content("");
            }
            return View();
        }
    }
}