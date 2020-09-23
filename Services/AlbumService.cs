using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumAPIv2.Factory;
using AlbumAPIv2.Models;
namespace AlbumAPIv2.Services
{
    public class AlbumService : IAlbumService
    {
        private List<IAlbum> albums = new List<IAlbum>();
        public AlbumService()
        {
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
    }
}
