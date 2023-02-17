using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    internal class SqlConnect
    {
        public SqlConnection baglanti()
        {
             SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7OU8OV4;Initial Catalog=HastaneProje;Integrated Security=True");
             baglan.Open();
             return baglan;
        }
    }
}
