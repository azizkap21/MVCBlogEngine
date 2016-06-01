using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlogEngine.Core.TransactionalModels
{
    public class EntityResultBase
    {

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }
        
        public string SuccessMessage { get; set; }
                
    }
}
