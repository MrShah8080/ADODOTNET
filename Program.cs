

using System.Data;
using System.Data.SqlClient;

string cennectionstring = "Server=(localdb)\\MSSQLLocalDB ; Database= StudentADONET_DB ; Trusted_Connection=True; TrustServerCertificate=True;";

using SqlConnection connection = new SqlConnection(cennectionstring);

connection.Open();

string sql = "SELECT * FROM StudentsADO";

SqlDataAdapter adapter = new SqlDataAdapter(sql , connection );

DataTable table = new DataTable();

adapter.Fill( table );

foreach(DataRow row in table.Rows)
{
    Console.WriteLine("Id: " + row["id"]  );
    Console.WriteLine("Name : " + row["Name"]  );
}


// changes