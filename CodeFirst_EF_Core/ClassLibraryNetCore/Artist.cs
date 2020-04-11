using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public partial class Artist
    {
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Album> Albums { get; set; }
        protected Artist() { }
    }
}