using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class DataStoreSettings
	{
		public int DataStoreSettingRowId { get; set; }
		public Guid BlogId { get; set; }
		public string ExtensionType { get; set; }
		public string ExtensionId { get; set; }
		public string Settings { get; set; }
	} 
 }