using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Blog_itla.DataAcces
{
    public abstract class ConecionSql
    {
       
            private readonly String ConecionString;

            public ConecionSql()
            {
                ConecionString = "Data Source=.;Initial Catalog=Blog;Integrated Security=True";
            }
            public SqlConnection GetSqlConnection()
            {
                return new SqlConnection(ConecionString);
            }
        
    }

}

