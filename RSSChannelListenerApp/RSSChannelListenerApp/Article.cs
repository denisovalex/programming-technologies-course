using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSChannelListenerApp
{
	public class Article
	{
		public int Id { get; private set; }
		public string Title { get; private set; }
		public string Link { get; private set; }
		public string Description { get; private set; }
		public string PubDate { get; private set; }

		public Article(int id, string title, string link, string description, string pubDate)
		{
			Id = id;
			Title = title;
			Link = link;
			Description = description;
			PubDate = pubDate;
		}
	}
}
