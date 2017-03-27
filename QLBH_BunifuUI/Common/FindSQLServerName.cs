using System.Data;
using System.Data.Sql;

namespace QLBH_BunifuUI.SQL
{
    public static class FindSqlServerName
    {
        public static DataTable GetAllSqlServerName()
        {
            // Retrieve the enumerator instance and then the data.  
            var instance = SqlDataSourceEnumerator.Instance;
            var table = instance.GetDataSources();

            // Display the contents of the table.  
            return table;
        }
    }
}
