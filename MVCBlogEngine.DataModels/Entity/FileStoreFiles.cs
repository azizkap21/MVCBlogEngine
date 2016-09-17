using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class FileStoreFiles
	{
		public Guid FileID { get; set; }
		public Guid ParentDirectoryID { get; set; }
		public string Name { get; set; }
		public string FullPath { get; set; }
		public Byte[] Contents { get; set; }
		public int Size { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastAccess { get; set; }
		public DateTime LastModify { get; set; }
	} 
 }