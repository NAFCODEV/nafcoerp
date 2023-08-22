namespace nafcoerp_v2.Models
{
    public class UserModel
    {
        public int auth_id { get; set; }
        public string auth_name { get; set; }
        public string auth_password { get; set; }
        public string auth_token { get; set; }
        public int auth_status { get; set; }
        public int auth_type { get; set; }
        public DateTime auth_update { get; set; }
        public string auth_email { get; set; }
        public string auth_mobileno { get; set; }
        public DateTime auth_lastlogintime { get; set; }
    }
}
