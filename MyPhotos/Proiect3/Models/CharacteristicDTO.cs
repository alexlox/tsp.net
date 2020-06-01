using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class CharacteristicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual List<MediaDTO> Media { get; set; }
        public virtual List<CharValueDTO> CharValues { get; set; }
    }
}
