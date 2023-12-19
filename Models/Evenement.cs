using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace hackatOrga.Models
{
    [Table("evenement")]
    public class Evenement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string libelle { get; set; }
        public DateTime date { get; set; }
        public TimeOnly heure { get; set; }
        public string duree { get; set; }
        public string salle { get; set; }
        public string type { get; set; }
        public int nbParticipants { get; set; }
        public string theme { get; set; }
        [ForeignKey(nameof(Intervenant))]
        public int idIntervenant { get; set; }

        public virtual Intervenant Intervenant { get; set; }
    }
}
