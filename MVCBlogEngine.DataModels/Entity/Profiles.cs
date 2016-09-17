using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Profiles
	{
		public int ProfileID { get; set; }
		public Guid BlogID { get; set; }
		public string UserName { get; set; }
		public string SettingName { get; set; }
		public string SettingValue { get; set; }
	} 
 }