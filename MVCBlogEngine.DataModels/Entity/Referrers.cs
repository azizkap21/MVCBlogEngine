using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class Referrers
	{
		public int ReferrerRowId { get; set; }
		public Guid BlogId { get; set; }
		public Guid ReferrerId { get; set; }
		public DateTime ReferralDay { get; set; }
		public string ReferrerUrl { get; set; }
		public int ReferralCount { get; set; }
		public string Url { get; set; }
		public bool IsSpam { get; set; }
	} 
 }