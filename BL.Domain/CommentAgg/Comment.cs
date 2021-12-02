using BL.Domain.ArticleAgg;


namespace BL.Domain.CommentAgg
{
    public class Comment
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public DateTime CreationDate { get; private set; }
        public int ArticleId { get; private set; }
        public int Status { get;private set; }

        public Article Article { get; private set; }

        protected Comment()
        {

        }

        public Comment(string name,string email,string message,int articleid)
        {
            Name = name;
            Email = email; 
            Message = message;
            ArticleId = articleid;
            CreationDate = DateTime.Now;
            Status = Statuses.New;
        }

        public void Confirm()
        {
            Status=Statuses.Confirm;
        }

        public void Cancel()
        {
            Status = Statuses.Canceld;
        }
    }

}
