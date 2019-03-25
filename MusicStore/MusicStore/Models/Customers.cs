using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string favoriteGenre { get; set; }
        public string favoriteSong { get; set; }
        public string picture { get; set; }
    }
}
