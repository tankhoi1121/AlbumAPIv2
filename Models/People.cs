using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace AlbumAPIv2.Models
{
    public class People : IAlbum
    {
        private static People _instance = new People();
        private List<string> _peopleList = new List<string>();
        static People()
        {

        }

        private People()
        {
            var prefix = Environment.GetEnvironmentVariable("prefix");
            var PeopleListExample = Directory
               .GetFiles
               (@"C:\Users\khoin\source\repos\AlbumAPIv2\AlbumAPIv2\wwwroot\People\");
            string category = "people";
            foreach (var path in PeopleListExample)
            {
                _peopleList.Add(prefix + category + "/" + Path.GetFileName(path));
            }
        }

        public static People Instance
        {
            get { return _instance; }
        }

        public List<string> GetAll()
        {
            return _peopleList;
        }
    }
}
