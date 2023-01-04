using System.ComponentModel.DataAnnotations;

namespace HIN_Ventures.Models.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string MessageText { get; set; }
    }
}
