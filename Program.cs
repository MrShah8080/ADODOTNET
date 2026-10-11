

using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Enter Name");
string name = Console.ReadLine();

Console.WriteLine("Enter Age");
int age = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter Mobile Number");
string mobile = Console.ReadLine();

string cennectionstring = "Server=(localdb)\\MSSQLLocalDB ; Database= StudentADONET_DB ; Trusted_Connection=True; TrustServerCertificate=True;";

using SqlConnection connection = new SqlConnection(cennectionstring);

connection.Open();

string sql = $"INSERT INTO StudentsADO (Name, Age, Mobile) VALUES('{name}', {age}, '{mobile}')";

using SqlCommand sqlCommand = new SqlCommand(sql, connection);

int rowAffected = sqlCommand.ExecuteNonQuery();

if(rowAffected > 0)
{
    Console.WriteLine($"{rowAffected} Row Affected");
    Console.WriteLine("Done");
}
else
{
    Console.WriteLine($"{rowAffected} Row Affected");
    Console.WriteLine("Error");
}




//SqlDataAdapter adapter = new SqlDataAdapter(sql , connection );

//DataTable table = new DataTable();

//adapter.Fill( table );

//foreach(DataRow row in table.Rows)
//{
//    Console.WriteLine("Id: " + row["id"]  );
//    Console.WriteLine("Name : " + row["Name"]  );
//}


// changes