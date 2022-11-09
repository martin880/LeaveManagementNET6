using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Display(Name = "Start Date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Leave Types")]
        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Request Comment ")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }
            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(RequestComments) });
            }
        }
    }
}
