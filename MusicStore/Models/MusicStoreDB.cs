using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDB : DbContext
    {
       
    
        public MusicStoreDB() : base("name=MusicStoreDB")
        {
        }

        public System.Data.Entity.DbSet<MusicStore.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MusicStore.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<MusicStore.Models.Genre> Genres { get; set; }
    }
}
