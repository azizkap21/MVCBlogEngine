using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PostNotify
	{
		public int PostNotifyID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PostID { get; set; }
		public string NotifyAddress { get; set; }
	} 
 }