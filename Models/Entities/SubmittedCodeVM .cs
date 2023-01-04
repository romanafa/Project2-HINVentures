using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIN_Ventures.Models.Entities
{
    public class SubmittedCodeVM
    {
        //public int CodeId { get; set; }
        public string? Code { get; set; }

        public int NumberOfLines { get; set; }
        //public bool IsApproved { get; set; }
        //public DateTime DateSubmitted { get; set; }

        public Assignment Assignment { get; set; }

    }
}
