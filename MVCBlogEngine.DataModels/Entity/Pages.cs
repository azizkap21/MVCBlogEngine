using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Pages
	{
		public int PageRowID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PageID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string PageContent { get; set; }
		public string Keywords { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		public bool IsPublished { get; set; }
		public bool IsFrontPage { get; set; }
		public Guid Parent { get; set; }
		public bool ShowInList { get; set; }
		public string Slug { get; set; }
		public bool IsDeleted { get; set; }
		public int SortOrder { get; set; }
	} 
 }