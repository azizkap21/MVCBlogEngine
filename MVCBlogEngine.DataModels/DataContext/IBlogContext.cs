using MVCBlogEngine.Database.Models;
using MVCBlogEngine.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogEngine.Database.DataContext
{
    public interface IBlogContext
    {
        DbContext BlogContext { get; set; }

        IDbSet<Blog> BlogSet { get; set; }
        IDbSet<BlogItem> BlogItemSet { get; set; }

        IDbSet<BlogUser> BlogUserSet { get; set; }

        IDbSet<CategoryItem> CategoryItemSet { get; set; }

        IDbSet<CommentDetail> CommentDetailSet { get; set; }

        IDbSet<CommentFilterItem> CommentFilterItemSet { get; set; }

    }
}
