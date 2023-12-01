using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hackatOrga.Models
{
    [Table("hackathon")]
    public class Hackathon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int nbPlacesMax { get; set; }
        public DateTime dateLimiteInscription { get; set; }
        public string titre { get; set; }
        public string ville { get; set; }
        public int codePostal { get; set; }
        public string rue { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public TimeOnly heureDebut { get; set; }
        public TimeOnly heureFin { get; set; }
    }
}
