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
        public IEnumerable<string> Index()
        {
            return _albumService.GetAlbum("Landscape");
        }
    }
}
