using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogEngine.Database.Models
{
    public class CategoryItem
    {
        /// <summary>
        /// If checked in the UI
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// Unique Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// Parent
        /// </summary>
        public SelectOption Parent { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Counter
        /// </summary>
        public int Count { get; set; }
    }
}
