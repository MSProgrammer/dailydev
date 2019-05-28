using System.Collections.Generic;
/// <summary>
/// This models is Head of Article Model 
/// <param name="article">A Category has Many article or one Article Has many categories<see langword="Article"></param>
/// </summary>
namespace Server.Domain.Models
{
    public class Category
    {
        public int id { get; set; }
        public string header { get; set; }
        public string title { get; set; }

        public IList<Article> article { get; set; } = new List<Article>();
    }
}