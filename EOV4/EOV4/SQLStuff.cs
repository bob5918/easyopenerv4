using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EOV4
{
    class SQLStuff
    {
        public static async Task<string> GetSQLResultAsync(string datatoget, string command)
        {
            MySqlConnection connection = new MySqlConnection("server=;user=;database=;port=;password=;");
            MySqlDataReader sqlData = null;
            try
            {
                await connection.OpenAsync();
                MySqlCommand sqlcommand = new MySqlCommand(command, connection);
                sqlData = sqlcommand.ExecuteReader();
                while (await sqlData.ReadAsync())
                {
                  
                    return sqlData[datatoget].ToString();
                }

            }
            catch (Exception e)
            {

                connection.Close();
                Console.WriteLine("Unable to grab the data! Please ask Bob5918 about this error!\r\n" + e.Message);
                return "Unable to grab the data! Please ask Bob5918 about this error!\r\n" + e.Message;

            }
            connection.Close();
          
            return "Failed to get SQL data!";
        }
    }
}
