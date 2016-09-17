using System;

namespace MvcBlogEngine.Database.Entity 
{
	public class QuickNotes
	{
		public int QuickNoteID { get; set; }
		public Guid NoteID { get; set; }
		public Guid BlogID { get; set; }
		public string UserName { get; set; }
		public string Note { get; set; }
		public DateTime Updated { get; set; }
	} 
 }