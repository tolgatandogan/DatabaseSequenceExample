using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Business.Abstract
{
    interface ICompanyService
    {

        void AddCompany();

        void ResetSequenceDaily();
    }
}
