using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Core.Entities.Abstract
{
    public interface IResult<T>
    {
        bool Success { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}
