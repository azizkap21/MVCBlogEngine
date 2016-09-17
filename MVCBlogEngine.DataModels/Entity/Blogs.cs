using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Blogs
	{
		public int BlogRowId { get; set; }
		public Guid BlogId { get; set; }
		public string BlogName { get; set; }
		public string Hostname { get; set; }
		public bool IsAnyTextBeforeHostnameAccepted { get; set; }
		public string StorageContainerName { get; set; }
		public string VirtualPath { get; set; }
		public bool IsPrimary { get; set; }
		public bool IsActive { get; set; }
		public bool IsSiteAggregation { get; set; }
	} 
 }