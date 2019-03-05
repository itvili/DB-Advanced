﻿namespace P01_HospitalDatabase.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Visitation
    {
        [Key]
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }

        public int MyProperty { get; set; }

        [MaxLength(250)]
        [Required]
        public string Comments { get; set; }
    
        public int PatientId { get; set; }        
        public Patient Patient { get; set; }
    }
}
