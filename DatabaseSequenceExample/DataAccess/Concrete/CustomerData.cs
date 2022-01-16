using DatabaseSequenceExample.Core.Entities.Concrete;
using DatabaseSequenceExample.Core.Manager;
using DatabaseSequenceExample.Core.Shared.Constants;
using DatabaseSequenceExample.DataAccess.Abstract;
using DatabaseSequenceExample.Models;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Dapper;
using DatabaseSequenceExample.Core.DataAccess.Concrete;
using DatabaseSequenceExample.DataAccess.Concrete.EntityFramework.Contexts;

namespace DatabaseSequenceExample.DataAccess.Concrete
{
    public class CustomerData : EfEntityRepositoryBase<Customer, SequenceExampleDbContext>, ICustomerData
    {
        private static readonly string DbCon = AppSetting.GetDbConn();

        public Result<long> GetDatatableSequenceValue(string sequenceTableName, string sequenceColumnName = null)
        {
            try
            {
                string sqlQuery = string.Empty;
                if (string.IsNullOrEmpty(sequenceColumnName))
                {
                    sqlQuery = $"SELECT NEXT VALUE FOR [dbo].[Seq_{sequenceTableName}_Id] AS SequenceValue";
                }
                else
                {
                    sqlQuery = $"SELECT NEXT VALUE FOR [dbo].[Seq_{sequenceTableName}_{sequenceColumnName}] AS SequenceValue";
                }

                long numResults;
                using (var connection = new SqlConnection(DbCon))
                {
                    numResults = connection.Query<long>(sql: sqlQuery).FirstOrDefault();
                }
                if (numResults > 0)
                {
                    return new Result<long>(true, Messages.Successful, numResults);
                }
                else
                {
                    return new Result<long>(false, Messages.DatabaseQueryError, 0);
                }
            }
            catch (Exception ex)
            {
                return new Result<long>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), 0);
            }
        }

     
    }
}
