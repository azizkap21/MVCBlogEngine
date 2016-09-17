using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class PostComment
	{
		public int PostCommentRowID { get; set; }
		public Guid BlogID { get; set; }
		public Guid PostCommentID { get; set; }
		public Guid PostID { get; set; }
		public Guid ParentCommentID { get; set; }
		public DateTime CommentDate { get; set; }
		public string Author { get; set; }
		public string Email { get; set; }
		public string Website { get; set; }
		public string Comment { get; set; }
		public string Country { get; set; }
		public string Ip { get; set; }
		public bool IsApproved { get; set; }
		public string ModeratedBy { get; set; }
		public string Avatar { get; set; }
		public bool IsSpam { get; set; }
		public bool IsDeleted { get; set; }
	} 
 }