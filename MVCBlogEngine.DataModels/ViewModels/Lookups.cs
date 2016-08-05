using System.Collections.Generic;

namespace MVCBlogEngine.Database.ViewModels
{
    /// <summary>
    /// Lookups
    /// </summary>
    public class Lookups
    {
        /// <summary>
        /// Cultures supported by BE
        /// </summary>
        public IEnumerable<SelectOptionViewModel> Cultures { get; set; }
        /// <summary>
        /// Roles for self registration
        /// </summary>
        public IEnumerable<SelectOptionViewModel> SelfRegisterRoles { get; set; }
        /// <summary>
        /// Page list
        /// </summary>
        public IEnumerable<SelectOptionViewModel> PageList { get; set; }
        /// <summary>
        /// List of blog authors
        /// </summary>
        public IEnumerable<SelectOptionViewModel> AuthorList { get; set; }
        /// <summary>
        /// Category list
        /// </summary>
        public IEnumerable<SelectOptionViewModel> CategoryList { get; set; }
        /// <summary>
        /// List of installed themes
        /// </summary>
        public IEnumerable<SelectOptionViewModel> InstalledThemes { get; set; }

        public EditorOptions PostOptions { get; set; }
        public EditorOptions PageOptions { get; set; }
    }
}
