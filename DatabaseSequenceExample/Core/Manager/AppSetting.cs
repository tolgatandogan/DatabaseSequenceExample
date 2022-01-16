using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.Core.Manager
{
    public static class AppSetting
    {
        public static string GetDbConn()
        {
            string ecomDb = "Server=.; Database=SequenceExample;Integrated Security=SSPI";
            return ecomDb;
        }
    }
}
