using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YoucodeReserv.Data
{
    public class Resrvation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingStudentId")]
        public Etudiants RequestingStudent { get; set; }
        public string RequestingStudentId { get; set; }
        [ForeignKey("ReservationTypeId")]
        public TypeReservation ReservationType { get; set; }
        public int ReservationTypeId { get; set; }
        public DateTime Date { get; set; }
    }
}
