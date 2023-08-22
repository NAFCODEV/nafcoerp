using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using nafcoerp_v2.Models;

namespace nafcoerp_v2.Services
{
    public class UserServices : Connections
    {
        
        private SqlCommand cm = new SqlCommand();
        private SqlDataReader odr;
        private string sql = "";

        public List<UserModel> getAlluser()
        {
            List<UserModel> _userlist = new List<UserModel>();
            //try
            //{
            //this.connection();
                this.cn.Open();
                this.sql = "SELECT *FROM app_auth order by auth_name asc";
                this.cm.CommandText = this.sql;
                this.cm.Connection = this.cn;
                odr = this.cm.ExecuteReader();
                while (odr.Read())
                {
                    _userlist.Add(
                        new UserModel()
                        {
                            auth_id = System.Convert.ToInt32(odr["auth_id"]),
                            auth_name = odr["auth_name"].ToString(),
                            auth_password = "",
                            auth_token = odr["auth_token"].ToString(),
                            auth_status = System.Convert.ToInt32(odr["auth_status"]),
                            auth_type = System.Convert.ToInt32(odr["auth_type"]),
                            auth_update = System.Convert.ToDateTime(odr["auth_update"]),
                            auth_email = odr["auth_email"].ToString(),
                            auth_mobileno = odr["auth_mobileno"].ToString(),
                            auth_lastlogintime = System.Convert.ToDateTime(odr["auth_lastlogintime"]),

                        }
                    );
                }
                this.odr.Close();
                this.cm.Dispose();
                this.cn.Close();
                return _userlist.ToList();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error on Query");
            //    Console.WriteLine(e.Message);
            //    return _userlist.ToList();
            //}
        }
    }
}
