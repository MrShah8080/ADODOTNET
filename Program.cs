

using System.Data;
using System.Data.SqlClient;

string cennectionstring = "Server=(localdb)\\MSSQLLocalDB ; Database= StudentADONET_DB ; Trusted_Connection=True; TrustServerCertificate=True;";

using SqlConnection connection = new SqlConnection(cennectionstring);

connection.Open();

string sql = "SELECT * FROM StudentsADO";


SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

DataTable table = new DataTable();

adapter.Fill(table);

foreach (DataRow row in table.Rows)
{
    Console.WriteLine("Id: " + row["id"]);
    Console.WriteLine("Name : " + row["Name"]);
}

















//using SqlCommand sqlCommand = new SqlCommand(sql , connection);

//SqlDataReader reader = sqlCommand.ExecuteReader();

//if (reader.HasRows) // yeh check kar rha hai iske pass row hai kya
//{
//    while (reader.Read())
//    {
//        Console.WriteLine("Id: "+ Convert.ToInt32( reader["id"]));
//        Console.WriteLine("---------------------------------------");
//        Console.WriteLine("Age: "+ Convert.ToInt32( reader["age"]));
//        Console.WriteLine("---------------------------------------");
//        Console.WriteLine("Name: "+ reader["Name"].ToString());
//        Console.WriteLine("---------------------------------------");
//        Console.WriteLine("Mobile: "+ reader["Mobile"].ToString()); 


//        Console.WriteLine("*****************************************");
//    }
//}







// changes