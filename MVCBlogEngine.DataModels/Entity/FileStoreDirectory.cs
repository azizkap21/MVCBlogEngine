using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class FileStoreDirectory
	{
		public Guid Id { get; set; }
		public Guid ParentID { get; set; }
		public Guid BlogID { get; set; }
		public string Name { get; set; }
		public string FullPath { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastAccess { get; set; }
		public DateTime LastModify { get; set; }
	} 
 }