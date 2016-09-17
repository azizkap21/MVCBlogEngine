using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class FileStoreFileThumbs
	{
		public Guid thumbnailId { get; set; }
		public Guid FileId { get; set; }
		public int size { get; set; }
		public Byte[] contents { get; set; }
	} 
 }