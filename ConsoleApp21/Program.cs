using System.Data.SqlClient;

namespace ConsoleApp21

{

    internal static class ZalupaHumana
    {
        public static void Main(string[] args)
        {
            
            string connectionString = @"Data Source = 46.39.232.190; Initial Catalog = Airport_Nuclear_Bomb;User Id = m0rp3x228; Password = vag!nA228##
;";
            string sqlExpression = "SELECT COUNT(*) FROM Flight_Data";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                object count = command.ExecuteScalar();
 
                command.CommandText = "SELECT MIN(Terminal_ID) FROM Gates";
                object minAge = command.ExecuteScalar();
 
                Console.WriteLine("В таблице {0} объектов", count);
                Console.WriteLine("Минимальное значение: {0}", minAge);
            }
        }

    }
}