using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Agency.Models
{
    public class Admin
    {
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "distanation must be between 2 and 15 letters")]
        public String country_1 { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "origin must be between 2 and 15 letters")]
        public String counrty_2 { get; set; }
        [Required]
        public string Time_1 { get; set; }
        [Required]
        public string Time_2 { get; set; }
        [Required]
        public int Total_Number_of_seats_1 { get; set; }
        [Required]
        public int Free_Number_of_seats_1 { get; set; }
        [Required]
        public int Total_Number_of_seats_2 { get; set; }
        [Required]
        public int Free_Number_of_seats_2 { get; set; }
        [Required]
        public float Price_ticket { get; set; }
        [Required]
        public string Date_1 { get; set; }
        [Required]
        public string Date_2 { get; set; }
        [Required]
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
    }
}