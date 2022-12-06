using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Planner
    {
        public int Id { get; set; }

        [Display(Name = "Planner Date")]
        [DataType(DataType.Date)]
        public DateTime PlannerDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Conducting { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Presiding { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SacramentHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string IntermediateHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string OpeningPrayer { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ClosingPrayer { get; set; }
    }
}
