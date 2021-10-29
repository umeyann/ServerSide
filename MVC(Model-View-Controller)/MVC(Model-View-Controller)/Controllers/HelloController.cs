// Microsoft
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // using に追加

// System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_Model_View_Controller_.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Form()
        //{
        //    ViewData["message"] = Request.Form["msg"];
        //    return View("Index");0
        //}

        //フォームを引数で受け取る




        [HttpPost]
        public IActionResult Form(string id, string password)
        {
            ViewData["id"] = id;
            ViewData["password"] = password;
            bool checkId = false;
            bool checkPass = false;
            // 現在時間取得
            string sessonTime = System.DateTime.Now.ToString("yyyyMMdd-hhmmss");

            if (id == "ECC")
            {
                checkId = true;
            }
            else
            {
                ViewData["IdError"] = "存在しないIDです";
                checkId = false;
            }

            if (password == "0144")
            {
                checkPass = true;
            }
            else
            {
                ViewData["passError"] = "パスワードが間違っています";
                checkPass = false;
            }

            if (checkId && checkPass)
            {

                return View("Index1");
            }


            return View("Index");
        }

        [Route("Hello/Query/{id?}/{name?}")]
        public IActionResult Query(int id, string name)
        {
            ViewData["message"] = "id = " + id + " , mame = " + name;
            return View();
        }

        [Route("Hello/Session/{id?}/{name?}")]
        public IActionResult Session(int id, string name)
        {
            ViewData["message"] = "セッションにIDとNameを保存しました。";
            HttpContext.Session.SetInt32("id", id);
            if (name == null) name = "";
            HttpContext.Session.SetString("name", name);
            return View();
        }

        [HttpGet]
        public IActionResult SessionCheck(int id, string name)
        {
            ViewData["message"] = "保存されているセッションの値を確認します。";
            ViewData["id"] = HttpContext.Session.GetInt32("id");
            ViewData["name"] = HttpContext.Session.GetString("name");
            return View("Session");
        }
    }
}
