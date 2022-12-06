using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SpeakerName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string SpeakerSubject { get; set; }
    }
}
