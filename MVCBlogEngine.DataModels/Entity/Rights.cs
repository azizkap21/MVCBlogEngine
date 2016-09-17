using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Rights
	{
		public int RightRowId { get; set; }
		public Guid BlogId { get; set; }
		public string RightName { get; set; }
	} 
 }