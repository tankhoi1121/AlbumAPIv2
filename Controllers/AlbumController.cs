using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlbumAPIv2.Services;
using AlbumAPIv2.Models;
using Microsoft.AspNetCore.Hosting;

namespace AlbumAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;
        private IHostingEnvironment _enviroment;
        public AlbumController(IHostingEnvironment env)
        {
            _albumService = new AlbumService();
            _enviroment = env;
        }
        [HttpGet]
        public IEnumerable<string> Index()
        {

            var res = new List<string>();
            res.AddRange(_albumService.GetAlbum("Landscape"));
            res.AddRange(_albumService.GetAlbum("People"));
            res.AddRange(_albumService.GetAlbum("Tech"));
            return res;
        }

        [HttpGet("landscape")]
        public IEnumerable<string> LandscapeList()
        {
            return _albumService.GetAlbum("Landscape");
        }

        [HttpGet("people")]
        public IEnumerable<string> PeopleList()
        {
            return _albumService.GetAlbum("People");
        }

        [HttpGet("tech")]
        public IEnumerable<string> TechList()
        {
            return _albumService.GetAlbum("Tech");
        }

        [HttpPost("upload")]
        public string OnPostUpload([FromForm(Name = "file")] IFormFile file, [FromForm] string subDir)
        {
            string s;
            if (file != null || file.Length != 0)
            {
                using (FileStream fs =
                    new FileStream((_enviroment.WebRootPath + "/" + subDir + "/" + file.FileName + ".jpg"), FileMode.Create))
                {
                    file.CopyToAsync(fs);

                }
                s = "OK";
            }
            else
            {
                s = "Not OK";
            }
            return s;
        }
    }
}
