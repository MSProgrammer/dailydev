using System.Collections.Generic;
/// <summary>
/// <param name="Article">a Comments Table has many Article <see langword="Article"/></param>
/// </summary>
namespace Server.Domain.Models
{
    public class Comments
    {
        public int id { get; set; }
        public string comment_body { get; set; }

        public int article_id { get; set; }
        public Article article { get; set; }

    }
}