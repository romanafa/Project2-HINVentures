using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIN_Ventures.Models.Entities
{
    public class SubmittedCode
    {
        [Key]
        public int CodeId { get; set; }
        public string Code { get; set; }

        public int NumberOfLines { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateSubmitted { get; set; }

        [ForeignKey("AssignmentId ")]
        public virtual Assignment Assignment { get; set; }

    }
}
