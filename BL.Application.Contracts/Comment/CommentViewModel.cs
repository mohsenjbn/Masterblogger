﻿


namespace BL.Application.Contracts.Comment
{
    public class CommentViewModel
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Message { get;  set; }
        public string CreationDate { get;  set; }
        public string ArticleName { get;  set; }
        public int Status { get; set; }

    }
}
