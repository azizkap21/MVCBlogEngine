using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PackageFiles
	{
		public string PackageId { get; set; }
		public int FileOrder { get; set; }
		public string FilePath { get; set; }
		public bool IsDirectory { get; set; }
	} 
 }