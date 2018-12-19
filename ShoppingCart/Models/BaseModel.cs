using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public long CreatedById { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public long ModifiedById { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
