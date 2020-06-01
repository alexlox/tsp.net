using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class CharValueDTO
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int CharacteristicId { get; set; }

        public virtual MediaDTO Media { get; set; }
        public virtual CharacteristicDTO Characteristic { get; set; }
    }
}
