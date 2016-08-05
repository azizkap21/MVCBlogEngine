using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogEngine.Database.Models
{
    public class BlogItem
    {
        /// <summary>
        /// Blog name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
