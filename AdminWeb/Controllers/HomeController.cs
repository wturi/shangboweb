using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Controllers
{
    [AboutError]
    public class HomeController : BaseController
    {
        //[OutputCache(Duration =10)]  缓存
        public ActionResult Index()
        {
            ViewBag.Title = "主页";
            ViewBag.ContentTitle = "主页";
            return View();
        }


        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ActionResult Login(string username,string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                Response.Redirect(Url.Action("Index", "Home"));
            }
            return View();
        }   

        /// <summary>
        /// 用户管理数据
        /// </summary>
        /// <returns></returns>
        public ActionResult Users()
        {
            ViewBag.ContentTitle = "用户管理";
            return View();
        }

        /// <summary>
        /// 用户留言管理
        /// </summary>
        /// <returns></returns>
        public ActionResult UserMessage()
        {
            ViewBag.ContentTitle = "用户管理";
            return View();

        }

        /// <summary>
        /// 二维码管理
        /// </summary>
        /// <returns></returns>
        public ActionResult QCode()
        {
            ViewBag.ContentTitle = "二维码管理";
            return View();
        }

        
    }
}