using Dapper;
using DatabaseSequenceExample.Core.Entities.Concrete;
using DatabaseSequenceExample.Core.Manager;
using DatabaseSequenceExample.Core.Shared.Constants;
using DatabaseSequenceExample.DataAccess.Abstract;
using DatabaseSequenceExample.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSequenceExample.DataAccess.Concrete
{
    public class CompanyData : ICompanyData
    {
        private static readonly string DbCon = AppSetting.GetDbConn();

        public Company Add(Company entity)
        {
            throw new NotImplementedException();
        }

        public Result<int> GetDatatableSequenceValue(string sequenceTableName, string sequenceColumnName = null)
        {
            try
            {
                string sqlQuery = string.Empty;
                if (string.IsNullOrEmpty(sequenceColumnName))
                {
                    sqlQuery = $"SELECT NEXT VALUE FOR [qcommerce].[Seq_{sequenceTableName}_Id] AS SequenceValue";
                }
                else
                {
                    sqlQuery = $"SELECT NEXT VALUE FOR [qcommerce].[Seq_{sequenceTableName}_{sequenceColumnName}] AS SequenceValue";
                }

                int numResults;
                using (var connection = new SqlConnection(DbCon))
                {
                    numResults = connection.Query<int>(sql: sqlQuery).FirstOrDefault();
                }
                if (numResults > 0)
                {
                    return new Result<int>(true, Messages.Successful, numResults);
                }
                else
                {
                    return new Result<int>(false, Messages.DatabaseQueryError, 0);
                }
            }
            catch (Exception ex)
            {
                return new Result<int>(false, string.Format("{0} {1}", Messages.DatabaseQueryError, ex.Message), 0);
            }
        }
    }
}
