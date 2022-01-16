using DatabaseSequenceExample.Core.DataAccess.Abstract;
using DatabaseSequenceExample.Core.Entities.Concrete;
using DatabaseSequenceExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.DataAccess.Abstract
{
    public interface ICompanyData : IEntityRepository<Company>
    {
        public Result<int> GetDatatableSequenceValue(string sequenceTableName, string sequenceColumnName = null);
    }
}
