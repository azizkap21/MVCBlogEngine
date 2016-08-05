namespace MVCBlogEngine.Database.ViewModels
{
    /// <summary>
    /// Used for dropdowns
    /// </summary>
    public class SelectOptionViewModel
    {
        /// <summary>
        /// Option name
        /// </summary>
        public string OptionName { get; set; }
        /// <summary>
        /// Option value
        /// </summary>
        public string OptionValue { get; set; }
        /// <summary>
        /// Is option selected
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
