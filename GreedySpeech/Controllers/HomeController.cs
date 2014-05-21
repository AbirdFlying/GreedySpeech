using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Caching;
using System.IO;
using NAudio.Wave;
namespace GreedySpeech.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Record()
        {
            var status = Request.Form["status"];
            byte[] temp = new byte[Request.Files[0].InputStream.Length];
            Request.Files[0].InputStream.Read(temp, 0, temp.Length);
            //CacheItemPolicy policy = new CacheItemPolicy();
            //if (cache.Contains("filecontents"))
            //{
            //    var list = cache["filecontents"] as List<byte>;
            //    list.AddRange(temp);
            //    cache.Set("filecontents", list, policy);
            //}
            //else
            //{
            //    var list = new List<byte>();
            //    list.AddRange(temp);
            //    cache.Set("filecontents", list, policy);
            //}
            //var status = Request.Form["status"];

            //if (status == "2")
            //{
            using (var fs = new FileStream("D:\\abc.wav", FileMode.Create, FileAccess.Write))
            {

                fs.Write(temp, 0, temp.Length);
            }
            //
            //WaveFormat waveFormat = new WaveFormat(8000, 8, 1);
            ////var list = cache["filecontents"] as List<byte>;
            ////var data = list.ToArray();
            ////fs.Write(data, 0, data.Length);

            //using (WaveFileWriter writer = new WaveFileWriter("D:\\abc.wav", new NAudio.Wave.WaveFormat(16000, 16, 1)))
            //{
            //    writer.WriteData(temp, 0, temp.Length);
            //}

            //var files = Request.Files[0];
            //files.SaveAs(Server.MapPath("/Audio//test.wav"));
            //}
            return Json(new { status = status });
        }

    }
}
