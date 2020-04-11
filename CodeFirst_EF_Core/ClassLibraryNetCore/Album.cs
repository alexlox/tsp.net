using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public partial class Album
    {
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }

        public ICollection<Artist> Artists { get; set; }
        protected Album() { }
    }
}