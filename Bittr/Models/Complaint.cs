namespace Bittr.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public double Progress { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
    }
}
