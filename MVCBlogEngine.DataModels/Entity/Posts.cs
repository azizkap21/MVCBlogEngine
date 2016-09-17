using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Posts
	{
		public int PostRowID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PostID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string PostContent { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		public string Author { get; set; }
		public bool IsPublished { get; set; }
		public bool IsCommentEnabled { get; set; }
		public int Raters { get; set; }
		public decimal Rating { get; set; }
		public string Slug { get; set; }
		public bool IsDeleted { get; set; }
	} 
 }