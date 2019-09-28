using IBLL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC;
namespace UI.Controllers
{
    public class PostClassifyController : Controller
    {
        // GET: PostClassify
        IPostClassifyBLL ipc = IocCreate.CreatePostClassifyBLL();
        IPostBLL ipb =IocCreate.CreatePostBLL();
        public ActionResult major_kind2()
        {
            List<PostClassifyModel> list = ipc.PostClassifySelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult major_kind()
        {
            return View();
        }
        public ActionResult major_kind_add()
        {
            return View();
        }

        public ActionResult major_kind_add2(PostClassifyModel pc)
        {
            PostClassifyModel pcm = new PostClassifyModel()
            {
                PostClassifyName = pc.PostClassifyName
            };
            if (ipc.PostClassifyAdd(pcm) > 0)
            {
                return Content("<script>alert('添加成功');window.location = '/PostClassify/major_kind'</script>");
            }
            return View();
        }

        //删除
        public ActionResult major_kind_Del(PostClassifyModel pc)
        {
            PostClassifyModel pcm = new PostClassifyModel()
            {
                PostClassifyId = pc.PostClassifyId
            };
            if (ipc.PostClassifyDelete(pcm) > 0)
            {
                return RedirectToAction("major_kind");
            }
            return View();
        }
        public ActionResult major()
        {
            return View();
        }
        public ActionResult major2()
        {
            List<Dictionary<string, string>> list = ipc.PostSel();
            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult major_add()
        {
            SelectList s = new SelectList(ipc.PostClassifySelect(), "PostClassifyId", "PostClassifyName", 1);
            ViewBag.s = s;
            return View();
        }

        public ActionResult major_add2(int PostClassifyId, string PostName)
        {
            PostModel p = new PostModel()
            {
                PostName = PostName,
                PostClassifyId = PostClassifyId

            };
            if (ipb.PostAdd(p) > 0)
            {
                return Content("<script>alert('添加成功');window.location = '/PostClassify/major'</script>");
            }
            return View();
        }

        public ActionResult major_del(int PostId)
        {
            PostModel pm = new PostModel()
            {
                PostId = PostId
            };
            if (ipb.PostDelete(pm) > 0)
            {
                return RedirectToAction("major2");
            }
            return View();
        }
    }
}