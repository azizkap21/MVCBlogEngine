using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Roles
	{
		public int RoleID { get; set; }
		public Guid BlogID { get; set; }
		public string Role { get; set; }
	} 
 }