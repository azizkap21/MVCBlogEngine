using System.Collections.Generic;

namespace MVCBlogEngine.Database.ViewModels
{
    /// <summary>
    /// Json friendly Role wrapper
    /// </summary>
    public class RoleItemViewModel
    {
        /// <summary>
        /// If checked in the UI
        /// </summary>
        public bool IsChecked { get; set; }
        /// <summary>
        /// Role Name
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// Is System Role
        /// </summary>
        public bool IsSystemRole { get; set; }
    }

    /// <summary>
    /// Group of permissions
    /// </summary>
    public class GroupViewModel
    {
        /// <summary>
        /// Empty constructor needed for serialization
        /// </summary>
        public GroupViewModel() { }
        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="title">Role title</param>
        public GroupViewModel(string title) 
        {
            Title = title;
            if (Permissions == null)
                Permissions = new List<PermissionViewModel>();
        }
        /// <summary>
        /// Role title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// List of rights
        /// </summary>
        public List<PermissionViewModel> Permissions { get; set; }
    }

    /// <summary>
    /// Permission
    /// </summary>
    public class PermissionViewModel
    {
        /// <summary>
        /// Right Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Checked if right allowed for the role
        /// </summary>
        public bool IsChecked { get; set; }
    }
}