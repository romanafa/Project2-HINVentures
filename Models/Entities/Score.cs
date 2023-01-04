namespace HIN_Ventures.Models.Entities
{
    public class Score
    {
        public Score()
        {
            this.Freelancers = new HashSet<Freelancer>();
        }

        public int ScoreId { get; set; }
        public string ScoreName { get; set; }

        public int ScoreValue { get; set; }

        public virtual ICollection<Freelancer> Freelancers { get; set; }
    }
}
