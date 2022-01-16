using DatabaseSequenceExample.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Business.Concrete
{
    class CompanyService : ICompanyService, IDisposable
    {
        public void AddCompany()
        {
            throw new NotImplementedException();
        }

        public void ResetSequenceDaily()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
