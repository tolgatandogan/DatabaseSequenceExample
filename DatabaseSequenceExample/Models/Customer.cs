using DatabaseSequenceExample.Core.Entities.Abstract;
using DatabaseSequenceExample.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Models
{
    [Table("Customer", Schema = "dbo")]
    public class Customer : EntityBase
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}
