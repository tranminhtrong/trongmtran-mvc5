using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration:DbConfiguration
    {
        public SchoolConfiguration()
        {
            //SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            //To set the maximum number of retries to 1 and the maximum delay to 30 seconds
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(1, TimeSpan.FromSeconds(30)));
        }
    }
}