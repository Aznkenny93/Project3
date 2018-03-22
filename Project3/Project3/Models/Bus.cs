using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    [Table("Bus")]
    public class Bus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Column(Order = 1)]
        public int RitNumber { get; set; }
        public int BusNumber { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Bustime { get; set; }
        public string Buslocation { get; set; }
        public string BusAdress { get; set; }
    }
}