using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class StopWords
	{
		public int StopWordRowId { get; set; }
		public Guid BlogId { get; set; }
		public string StopWord { get; set; }
	} 
 }