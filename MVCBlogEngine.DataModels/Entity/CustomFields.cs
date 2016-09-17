using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class CustomFields
	{
		public string CustomType { get; set; }
		public string ObjectId { get; set; }
		public Guid BlogId { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
		public string Attribute { get; set; }
	} 
 }