using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PingService
	{
		public int PingServiceID { get; set; }
		public Guid BlogID { get; set; }
		public string Link { get; set; }
	} 
 }