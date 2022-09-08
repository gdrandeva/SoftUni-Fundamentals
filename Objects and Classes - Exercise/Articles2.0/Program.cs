using System;
using System.Collections.Generic;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < countOfArticles; i++)
            {

            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Content = content;
            Title = title;
        }


        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }




        public override string ToString()
        {
            return $"{Title} - {Content}:{Author}";
        }

    }
}
