using QueryBAL.QueryBALInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBAL.QueryLogics
{
    public class QueryBuilderLogicClass : IQueryLogics
    {
        string IQueryLogics.CreateTable(string tableName)
        {
            return "CREATE TABLE " + tableName +"(ColumnName Datatype);";
        }
    }
}
