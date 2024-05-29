using Ndtlesson6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ndtlesson6.Controllers
{
    public class NdtSongController : Controller
    {
        private static List<NdtSong> ndtSongs = new List<NdtSong>()
        {
            new NdtSong {Id=1,NdtTitle="Nguyễn Danh Trường",NdtAuthor="K22CNTT4",NdtArlist="NTU",NdtYearRelease=2020},
            new NdtSong {Id=2,NdtTitle="Nguyễn Danh T",NdtAuthor="K22CNTT4",NdtArlist="NTU",NdtYearRelease=2020},
        };
        // GET: NdtSong
        /// <summary>
        /// NdtAuthor:Nguyễn Danh Trường
        /// </summary>
        /// <returns></returns>
        public ActionResult NdtIndex()
        {
            return View(ndtSongs);
        }
        // GET:NdtCreate
        /// <summary>
        /// Form Thêm mới bài hát 
        /// NdtAuthor:Nguyễn Danh Trường

        /// </summary>
        /// <returns></returns>
        public ActionResult NdtCreate()
        {
            var ndtSong = new NdtSong();
            return View(ndtSong);

        }
    }
}