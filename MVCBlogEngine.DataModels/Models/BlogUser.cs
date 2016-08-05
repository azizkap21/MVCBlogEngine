using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogEngine.Database.Models
{
    public class BlogUser
    {
        /// <summary>
        /// If checked in the UI
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// User Name
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
        /// <summary>
        /// Old Password
        /// </summary>
        public string OldPassword { get; set; }

        /// <summary>
        /// User profile
        /// </summary>
        public Profile Profile { get; set; }
        /// <summary>
        /// User roles
        /// </summary>
        public List<RoleItem> Roles { get; set; }
    }
}
