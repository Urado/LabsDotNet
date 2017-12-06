using System;
using System.Data.Entity;
using System.Linq;
using PocketBook.Model.Enttity;

namespace PocketBook.Model
{
    public class PocketBookDB : DbContext
    {
        public PocketBookDB()
            : base("name=PocketBookDB")
        {
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<EMail> EMails { get; set; }
    }
}