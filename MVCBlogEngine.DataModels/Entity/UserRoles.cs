using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class UserRoles
	{
		public int UserRoleID { get; set; }
		public Guid BlogID { get; set; }
		public string UserName { get; set; }
		public string Role { get; set; }
	} 
 }