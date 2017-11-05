using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventHubApp.Models
{
    public class Event
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public ApplicationUser Speaker { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }
    }
}