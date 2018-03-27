using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project3.Models
{
    [Table("Parking")]
    public class Parking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string ParkingKey { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string ParkingName { get; set; }
        public string ParkingCode { get; set; }
        public string ParkingType { get; set; }
    }
}