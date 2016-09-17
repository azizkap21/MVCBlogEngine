using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Categories
	{
		public int CategoryRowID { get; set; }
		public Guid BlogID { get; set; }
		public Guid CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public Guid ParentID { get; set; }
	} 
 }