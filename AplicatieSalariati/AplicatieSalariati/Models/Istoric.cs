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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IstoricId { get; set; }

        public string PacientCNP { get; set; }

        public string Diagnostic { get; set; }

        public Pacient Pacient { get; set; }

        public string Tratament { get; set; }

        public bool Internare { get; set; }

        public string Spital { get; set; }

        public string Sectie { get; set; }

        public DateTime Data { get; set; }

        public string ZileSpitalizare { get; set; }

        public bool InterventieChirurgicala { get; set; }

        public string DetaliiInterventie { get; set; }

        [ForeignKey("IstoricId")]
        public ICollection<RetetaModel> Retete { get; set; }
    }
}
