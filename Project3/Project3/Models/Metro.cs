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
        public int MetroNumber  { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Tramtime { get; set; }
        public string Tramlocation { get; set; }
        public string TramAdress { get; set; }
    }
}