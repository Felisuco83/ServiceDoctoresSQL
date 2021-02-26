using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSQL.Models
{
    [DataContract]
    [Table("DOCTOR")]
    public class Doctor
    {
        [DataMember]
        [Key]
        [Column("DOCTOR_NO")]
        public int IdDoctor { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Especialidad { get; set; }
        [DataMember]
        public int Salario { get; set; }
    }
}
