using System.ComponentModel.DataAnnotations;
using HIN_Ventures.Models.Entities;

namespace HIN_Ventures.Models.Viewmodels
{
    public class AssignmentVM
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string? CustomerId { get; set; }

        public List<string>? Specialities { get; set; }
        
    }
}
