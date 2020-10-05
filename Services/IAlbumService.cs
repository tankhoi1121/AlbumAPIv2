using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumAPIv2.Services
{
    public interface IAlbumService
    {
        bool IsChange(List<string> album);
        string Upload(IFormFile formFile, string subDir);
    }
}
