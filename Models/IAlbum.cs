using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumAPIv2.Models
{
    public interface IAlbum
    {
        List<string> GetAll();
    }
}
