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
    public class AttributeTypeController : Controller
    {
        IAttributeTypeBLL iat = IocCreate.CreateAttributeTypeBLL();
        // GET: AttributeType
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Del(int id)
        {
            AttributeNameModel an = new AttributeNameModel() { ANID = id};
            if (iat.AttributeNameDelete(an) > 0)
            {
                return Content("");
            }
            return View();
        }
        public ActionResult Index2()
        {
            List<AttributeNameModel> list = iat.AttributeNameSelect();
            return Content(JsonConvert.SerializeObject(list));
            
        }
        [HttpGet]
        public ActionResult Add()
        {
            SelectList sl = new SelectList(iat.AttributeTypeSelect(),"ATID","ATName",1);
            ViewBag.s = sl;
            return View();
        }
        [HttpPost]
        public ActionResult Add(int ATID,string ANName)
        {
            AttributeNameModel an = new AttributeNameModel() { ANName=ANName,ATID=ATID};
            if (iat.AttributeNameAdd(an)>0)
            {
                return Content("<script>alert('添加成功');window.location.href='Index'</script>");
            }
            //return Content("<script>alert("+ATID.ToString()+" "+ANName+");window.location.href='Index'</script>");
            return View();
        }
    }
}