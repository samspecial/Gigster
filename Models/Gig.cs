using System;
using System.ComponentModel.DataAnnotations;

namespace Gigster.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Field can not be empty")]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required(ErrorMessage ="Venue field required")]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required(ErrorMessage ="Field can not be empty")]
        public Genre Genre { get; set; }
    }
}
