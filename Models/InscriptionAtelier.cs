﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace hackatOrga.Models
{
    [Table("inscription_atelier")]
    public class InscriptionAtelier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        [ForeignKey(nameof(Evenement))]
        public int idAtelier { get; set; }

        public virtual Evenement Evenement { get; set; }


    }
}