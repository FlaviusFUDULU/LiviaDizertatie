using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieSalariati.Models
{
    public class Medic
    {
        [Key]
        [Display(Name = "CNP")]
        public string CNP { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string Prenume { get; set; }

        public string Email { get; set; }

        [Required]
        public string Adresa { get; set; }

        [Display(Name = "Numar de telefon")]
        public string Numartelefon { get; set; }

        [Display(Name = "Data nașterii")]
        public DateTime DataNastertii { get; set; }
    }
}
