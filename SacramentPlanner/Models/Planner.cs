using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public class Planner
    {
        public int PlannerId { get; set; }

        [Display(Name = "Planner Date")]
        [DataType(DataType.Date)]
        public DateTime PlannerDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Conducting { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Presiding { get; set; }

        [Display(Name = "Opening Hymn")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string ClosingHymn { get; set; }

        [Display(Name = "Intermediate Hymn")]
        [StringLength(60, MinimumLength = 3)]
        public string IntermediateHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string ClosingPrayer { get; set; }

        [Display(Name = "Speaker 1")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Speaker1 { get; set; }

        [Display(Name = "Speaker 2")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Speaker2 { get; set; }

        [Display(Name = "Speaker 3")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Speaker3 { get; set; }

        [Display(Name = "Topic 1")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Topic1 { get; set; }

        [Display(Name = "Topic 2")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Topic2 { get; set; }

        [Display(Name = "Topic 3")]
        [StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Topic3 { get; set; }

        public virtual ICollection<Speaker> Speakers { get; set; }
        
        //public List<string>? Peeps { get; set; }
        
        //public List<Speaker>? Speakers { get; set; }

        //public List<Speaker>? Topics { get; set; }
    }
}
