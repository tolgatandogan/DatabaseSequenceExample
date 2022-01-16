using DatabaseSequenceExample.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Core.Entities.Concrete
{
    public class EntityBase : IEntity
    {
        public DateTime CreatedDatetime { get; set; } = Convert.ToDateTime((DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        public string CreatedUser { get; set; }
        public DateTime ModifiedDatetime { get; set; } = Convert.ToDateTime((DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        public string ModifiedUser { get; set; }
    }
}
