using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AlbumAPIv2.Services;
using AlbumAPIv2.Models;

namespace AlbumAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;
        public AlbumController()
        {
            _albumService = new AlbumService();
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
    }
}
