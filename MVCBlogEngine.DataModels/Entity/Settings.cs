using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Settings
	{
		public int SettingRowId { get; set; }
		public Guid BlogId { get; set; }
		public string SettingName { get; set; }
		public string SettingValue { get; set; }
	} 
 }