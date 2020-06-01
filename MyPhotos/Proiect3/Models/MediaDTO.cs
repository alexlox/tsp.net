using System;
using System.Collections.Generic;

namespace Proiect3.Models
{
    public class MediaDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string AbsPath { get; set; }
        public string Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual List<CharacteristicDTO> Characteristics { get; set; }
        public virtual CharValueDTO CharValue { get; set; }
    }
}
