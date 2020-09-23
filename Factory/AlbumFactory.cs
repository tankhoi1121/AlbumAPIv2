using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumAPIv2.Models;

namespace AlbumAPIv2.Factory
{

    public class AlbumFactory
    {
        private static AlbumFactory _instance = new AlbumFactory();
        static AlbumFactory()
        {

        }

        private AlbumFactory()
        {

        }

        public static AlbumFactory Instance
        {
            get { return _instance; }
        }

        public IAlbum CreateAlbum(string type)
        {
            switch (type)
            {
                case "Landscape":
                    return Landscape.Instance;
            }
            return null;
        }
    }

}
