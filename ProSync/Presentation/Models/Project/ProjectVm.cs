using System.ComponentModel.DataAnnotations;

namespace ProSync.Presentation.Models.Project
{
    public class ProjectVm
    {
        public int? ProjectId { get; set; }
        public int? ProfessionalId { get; set; }
        [Display(Name = "Client")]
        public int? ClientId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Start Date")]
        public DateTimeOffset? StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTimeOffset? EndDate { get; set; }
    }
}
