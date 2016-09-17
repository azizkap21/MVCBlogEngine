using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class RightRoles
	{
		public int RightRoleRowId { get; set; }
		public Guid BlogId { get; set; }
		public string RightName { get; set; }
		public string Role { get; set; }
	} 
 }