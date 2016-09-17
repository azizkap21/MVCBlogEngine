using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Users
	{
		public int UserID { get; set; }
		public Guid BlogID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public DateTime LastLoginTime { get; set; }
		public string EmailAddress { get; set; }
	} 
 }