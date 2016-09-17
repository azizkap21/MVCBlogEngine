using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PostCategory
	{
		public int PostCategoryID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PostID { get; set; }
		public Guid CategoryID { get; set; }
	} 
 }