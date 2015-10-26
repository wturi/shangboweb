using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Controllers
{
    public class NoticeController : BaseController
    {
        /// <summary>
        /// 发布
        /// </summary>
        /// <returns></returns>
        public ActionResult Release()
        {
            ViewBag.Title = "内容发布";
            return View();
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <returns></returns>
        public ActionResult Audit()
        {
            ViewBag.Title = "内容审核";
            return View();
        }

        /// <summary>
        /// 二维码
        /// </summary>
        /// <returns></returns>
        public ActionResult QRCode()
        {
            ViewBag.Title = "二维码";
            return View();
        }
    }
}