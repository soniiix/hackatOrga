using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hackatOrga.Models
{
    [Table("hackathon_evenement")]
    public class HackathonEvenement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey(nameof(Hackathon))]
        public int hackathon_id { get; set; }
        [ForeignKey(nameof(Evenement))]
        public int evenement_id { get; set; }

        public virtual Hackathon Hackathon { get; set; }
        public virtual Evenement Evenement{ get; set; }
    }
}
