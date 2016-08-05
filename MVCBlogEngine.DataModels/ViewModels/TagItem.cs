namespace MVCBlogEngine.Database.ViewModels
{
    /// <summary>
    /// The tag item
    /// </summary>
    public class TagItem
    {
        /// <summary>
        /// If checked in the UI
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// Tag Name
        /// </summary>
        public string TagName { get; set; }
        /// <summary>
        /// Tag Count
        /// </summary>
        public int TagCount { get; set; }
    }
}
