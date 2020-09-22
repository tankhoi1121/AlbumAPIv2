using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumAPIv2.Models
{
    public class Landscape : IAlbum
    {
        private static Landscape _instance = new Landscape();
        private List<string> _landScapeList = new List<string>();
        static Landscape()
        {

        }

        private Landscape()
        {
            _landScapeList.Add("http://localhost:4999/api/album/landscape/991.jpg");
            _landScapeList.Add("http://localhost:4999/api/album/landscape/9911.jpg");
            _landScapeList.Add("http://localhost:4999/api/album/landscape/9591.jpg");
            _landScapeList.Add("http://localhost:4999/api/album/landscape/691.jpg");

        }

        public static Landscape Instance
        {
            get { return _instance; }
        }

        public List<string> GetAll()
        {
            return _landScapeList;
        }
    }
}
