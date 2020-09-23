using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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
            var prefix = Environment.GetEnvironmentVariable("prefix");
            var ListLandscapeExample = Directory
               .GetFiles
               (@"C:\Users\khoin\source\repos\AlbumAPIv2\AlbumAPIv2\wwwroot\Landscape\");
            string category = "landscape";
            foreach (var path in ListLandscapeExample)
            {
                _landScapeList.Add(prefix + category + "/" + Path.GetFileName(path));
            }
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
