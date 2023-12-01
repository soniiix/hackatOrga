using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace hackatOrga.Models
{
    [Table("participant")]
    public class Participant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public int tel { get; set; }
        public DateTime dateNaissance { get; set; }
        public string lienPortfolio { get; set; }
        public string mdp { get; set; }
    }
}
