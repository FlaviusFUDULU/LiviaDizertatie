using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieSalariati.Models
{
    public class Istoric
    {
        [Key]
        public int IstoricId { get; set; }

        public string PacientCNP { get; set; }

        public string Diagnostic { get; set; }

        public Pacient Pacient { get; set; }

    }
}
