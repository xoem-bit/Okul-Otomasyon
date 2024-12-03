using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Efe_1
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BMG5BKD\MSSQLSERVER01;Initial Catalog=OkulOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
