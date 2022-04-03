namespace CommentServiceAPI
{
    public class CommentItem
    {
        public int Id { get; set; }

        public int ReportId { get; set; }

        public Guid UserId { get; set; }

        public string? Title { get; set; }

        public DateTime Created { get; set; }

        public string? Comment { get; set; }
    }
}
