using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumAPIv2.Factory;
using AlbumAPIv2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AlbumAPIv2.Services
{
    public class AlbumService : IAlbumService
    {
        private List<IAlbum> albums = new List<IAlbum>();
        private IHostingEnvironment _enviroment;
        public AlbumService(IHostingEnvironment env)
        {
            _enviroment = env;
            AlbumFactory _albumFactory = AlbumFactory.Instance;
            albums.Add(_albumFactory.CreateAlbum("Landscape"));
            albums.Add(_albumFactory.CreateAlbum("People"));
            albums.Add(_albumFactory.CreateAlbum("Tech"));
        }
        public bool IsChange(List<string> album)
        {
            if (album != null)
            {
                Console.WriteLine("Has Checked");
                return true;
            }
            else
            {
                Console.WriteLine("Done Checked");
                return false;
            }
        }

        public List<string> GetAlbum(string typeAlbum)
        {
            if (typeAlbum == "Landscape")
            {
                this.IsChange(albums[0].GetAll());
                return albums[0].GetAll();
            }
            else if (typeAlbum == "People")
            {
                this.IsChange(albums[1].GetAll());
                return albums[1].GetAll();
            }
            else if (typeAlbum == "Tech")
            {
                this.IsChange(albums[2].GetAll());
                return albums[2].GetAll();
            }
            return null;
        }

        public string Upload(IFormFile formFile, string subDir)
        {
            string s;
            if (formFile != null || formFile.Length != 0)
            {
                using (FileStream fs =
                    new FileStream((_enviroment.WebRootPath + "/" + subDir + "/" + formFile.FileName), FileMode.Create))
                {
                    formFile.CopyToAsync(fs);

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
