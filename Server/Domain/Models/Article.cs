using System.Collections.Generic;

namespace Server.Domain.Models
{
    /// <summary>
    /// This model is child of Category
    /// <param name="category_id">Category Id is Refrences param<see langword="int"/></param>
    /// <param name="category">It is category by by the Category type<see langword="category"/></param>
    /// <param name="article_comments">refer to the comments will included with articles<see langword="Comments"/></param>
    /// </summary>
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public IList<Comments> article_comments { get; set; } = new List<Comments>();

        public int category_id { get; set; }
        public Category category { get; set; }

    }

}