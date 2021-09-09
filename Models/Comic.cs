using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicCache.Models
{
    public class Comic
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Issue Number")]
        [Required]
        public int IssueNumber {get; set;}

        [Display(Name = "Year Released")]
        [Required]
        public int YearReleased { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Display(Name = "Box Location")]
        [Required]
        public int BoxLocation { get; set; }
    }
}
