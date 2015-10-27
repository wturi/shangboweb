using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminWeb.Controllers
{
    public class FilesController : BaseController
    {
        /// <summary>
        /// 文件管理
        /// </summary>
        /// <returns></returns>
        public ActionResult FileManagement()
        {
            ViewBag.Title = "文件管理";
            return View();
        }

        /// <summary>
        /// 数据管理
        /// </summary>
        /// <returns></returns>
        public ActionResult DataManagement()
        {
            ViewBag.Title = "数据管理";
            return View();
        }
    }
}