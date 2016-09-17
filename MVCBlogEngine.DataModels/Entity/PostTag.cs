using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PostTag
	{
		public int PostTagID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PostID { get; set; }
		public string Tag { get; set; }
	} 
 }