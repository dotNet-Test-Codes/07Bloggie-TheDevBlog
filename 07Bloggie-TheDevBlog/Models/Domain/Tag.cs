﻿namespace _07Bloggie_TheDevBlog.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BlogPostId { get; set; }

    }
}
