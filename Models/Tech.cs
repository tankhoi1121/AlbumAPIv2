using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace AlbumAPIv2.Models
{
    public class Tech : IAlbum
    {
        private static Tech _instance = new Tech();
        private List<string> _techList = new List<string>();

        static Tech()
        {

        }

        private Tech()
        {
            var prefix = Environment.GetEnvironmentVariable("prefix");
            var TechListExample = Directory
               .GetFiles
               (@"C:\Users\khoin\source\repos\AlbumAPIv2\AlbumAPIv2\wwwroot\Tech\");
            string category = "tech";
            foreach (var path in TechListExample)
            {
                _techList.Add(prefix + category + "/" + Path.GetFileName(path));
            }
        }

        public static Tech Instance
        {
            get { return _instance; }
        }

        public List<string> GetAll()
        {
            return _techList;
        }
    }
}
