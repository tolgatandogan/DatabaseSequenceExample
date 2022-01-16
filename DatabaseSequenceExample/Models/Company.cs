using DatabaseSequenceExample.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Models
{
    [Table("Company", Schema = "dbo")]
    public class Company : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
