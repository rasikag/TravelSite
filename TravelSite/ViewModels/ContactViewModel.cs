using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TravelSite.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(255,MinimumLength =7)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(1024,MinimumLength =10)]
        public string Message { get; set; }
    }
}
