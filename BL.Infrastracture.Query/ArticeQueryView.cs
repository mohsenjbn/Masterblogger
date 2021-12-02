namespace BL.Infrastracture.Query
{
    public class ArticeQueryView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ShortDescribtion { get; set; }
        public string Content { get; set; }
        public string CreationDate { get; set; }
        public string CategoryName { get; set; }
        public int Commentcount { get; set; }

        public List<CommentQueryView> Comments { get; set; }

    }
}