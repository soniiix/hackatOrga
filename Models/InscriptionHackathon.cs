using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hackatOrga.Models
{
    [Table("inscription_hackathon")]
    public class InscriptionHackathon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime date { get; set; }
        [ForeignKey(nameof(Participant))]
        public int idParticipant { get; set; }
        [ForeignKey(nameof(Hackathon))]
        public int idHackathon { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual Hackathon Hackathon { get; set; }
    }
}
