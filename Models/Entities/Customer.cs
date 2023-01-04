namespace HIN_Ventures.Models.Entities
{
    public class Customer : ApplicationUser
    {
        public bool IsSubscriber { get; set; }

        public virtual List<Assignment> Assignments { get; set; }
        
        public Subscription? Subscription { get; set; }
    }
}
