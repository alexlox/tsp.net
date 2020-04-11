using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public partial class People
    {
        public int Id { get; set; }
        
        [MaxLength(10)]
        public string FirstName { get; set; }
        
        [MaxLength(10)]
        public string MiddleName { get; set; }

        [MaxLength(10)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string TelephoneNumber { get; set; }
        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        //public int Deleted { get; set; }
        protected People() { }
    }
}