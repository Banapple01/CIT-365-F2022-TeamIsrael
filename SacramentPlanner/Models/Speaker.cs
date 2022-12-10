using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SpeakerName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SpeakerSubject { get; set; }

        public Planner Planner { get; set; }
        //some stuff

        //public virtual ICollection<Planner> Planners { get; set; }
    }
}
