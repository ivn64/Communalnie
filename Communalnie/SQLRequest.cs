using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Communalnie
{
    class SQLRequest
    {
        private string connStr = "server=localhost;user=root;database=Communalnie;password=;";        
        private MySqlConnection conn;

        public SQLRequest()
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        private List<string> SqlRequest(List<string> s, string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int i = 0;
                s.Add(reader.GetString(0));
                i++;
            }
            reader.Close();
            return s;
        }

        public List<string> SqlRequest(string request)
        {
            List<string> s = new List<string>();
            string sql = request;
            s = SqlRequest(s, sql);
            return s;
        }

        public void ConnectionClose()
        {
            conn.Close();
        }
    }
}
