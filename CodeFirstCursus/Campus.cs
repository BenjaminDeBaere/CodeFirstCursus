using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCursus
{
    public class Campus
    {
        public int CampusId { get; set; }
        [StringLength(50)]
        public string Naam { get; set; }
        public Adres Adres { get; set; }
    }
}

