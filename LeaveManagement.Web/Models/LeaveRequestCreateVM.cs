using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM
    {
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Leave Types")]
        public int LeaveTypeId { get; set; }
        public SelectList LeaveTypes { get; set; }

        [Display(Name = "Request Comment ")]
        public string RequestComments { get; set; }

    }
}
