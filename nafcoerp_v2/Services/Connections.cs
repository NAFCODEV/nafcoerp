using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace nafcoerp_v2.Services
{
    public class Connections
    {
        
        public SqlConnection cn = new SqlConnection(@"Data Source=nafcoit-pc\sqlexpress;Initial Catalog=nafcoerp;Persist Security Info=True;TrustServerCertificate=True;User ID=sa;Password=sa");
        
        public void connection()
        {
            
            
            try
            {
                this.cn.Open();
                Console.WriteLine("COnnection ok");
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
