using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    [Table("Metro")]
    public class Metro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Column(Order = 1)]
        public int RitNumber { get; set; }
        public string MetroNumber  { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Metrotime { get; set; }
        public string Metrolocation { get; set; }
        public string MetroAdress { get; set; }
    }
}