using QuanLyCuaHangSach;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2.Helpers
{
    internal class ConnectionHelper
    {
        private static string FindName()
        {
            foreach (ConnectionStringSettings cs in ConfigurationManager.ConnectionStrings)
            {
                if (cs.ProviderName == "System.Data.SqlClient" && cs.Name != "LocalSqlServer")
                    return cs.Name;
            }
            return null;
        }

        public static string GetConnectionString()
        {
            string name = FindName();
            return name == null ? null : ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        // Sửa lại đoạn này để luôn truyền chuỗi kết nối vào QLSachDataContext
        public static QLSachDataContext CreateContext()
        {
            string connStr = GetConnectionString();
            return new QLSachDataContext(connStr);
        }

        public static void ReadBuilder(out string server, out string db, out string user, out string pass, out bool isWinAuth)
        {
            server = ""; db = ""; user = ""; pass = ""; isWinAuth = true;
            try
            {
                string connStr = GetConnectionString();
                if (!string.IsNullOrEmpty(connStr))
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connStr);
                    server = builder.DataSource;
                    db = builder.InitialCatalog;
                    isWinAuth = builder.IntegratedSecurity;
                    if (!isWinAuth) { user = builder.UserID; pass = builder.Password; }
                }
            }
            catch { }
        }

        public static bool Test(string server, string db, string user, string pass, bool isWinAuth)
        {
            string connStr = isWinAuth
                ? $"Data Source={server};Initial Catalog={db};Integrated Security=True"
                : $"Data Source={server};Initial Catalog={db};User Id={user};Password={pass};";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try { conn.Open(); return true; } catch { return false; }
            }
        }

        public static void Save(string server, string db, string user, string pass, bool isWinAuth)
        {
            string connStr = isWinAuth
                ? $"Data Source={server};Initial Catalog={db};Integrated Security=True"
                : $"Data Source={server};Initial Catalog={db};User Id={user};Password={pass};"; // Lưu ý format chuỗi kết nối

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string name = FindName() ?? "WindowsFormsApp2.Properties.Settings.QuanLyCuaHangSachConnectionString";

            if (config.ConnectionStrings.ConnectionStrings[name] != null)
            {
                config.ConnectionStrings.ConnectionStrings[name].ConnectionString = connStr;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
        }
    }
}