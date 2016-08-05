using System.Collections.Generic;

namespace MVCBlogEngine.Database.ViewModels
{
    public class TrashVM
    {
        /// <summary>
        /// List of trash items
        /// </summary>
        public List<TrashItem> Items { get; set; }
        /// <summary>
        /// Total counter
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// Max number of items to keep in the trash
        /// </summary>
        public int Threshold { get; set; }
    }
}
