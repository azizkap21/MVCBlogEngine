using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class BlogRollItems
	{
		public int BlogRollRowId { get; set; }
		public Guid BlogId { get; set; }
		public Guid BlogRollId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string BlogUrl { get; set; }
		public string FeedUrl { get; set; }
		public string Xfn { get; set; }
		public int SortIndex { get; set; }
	} 
 }