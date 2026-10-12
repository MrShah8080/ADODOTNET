


using Microsoft.Data.SqlClient;

Console.WriteLine("Enter Id");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Name");
string name = Console.ReadLine();

Console.WriteLine("Enter Age");
int age = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter Mobile Number");
string mobile = Console.ReadLine();

string cennectionstring = "Server=(localdb)\\MSSQLLocalDB ; Database= StudentADONET_DB ; Trusted_Connection=True; TrustServerCertificate=True;";

using SqlConnection connection = new SqlConnection(cennectionstring);

connection.Open();

string sql = $"UPDATE StudentsADO SET Name = '{name}' , Age = {age} , Mobile = '{mobile}'  WHERE Id = {id} ";

using SqlCommand sqlCommand = new SqlCommand(sql, connection);

int rowAffected = sqlCommand.ExecuteNonQuery();

if(rowAffected > 0)
{
    Console.WriteLine($"{rowAffected} Row Updated");
    Console.WriteLine("UPDATE Successful");
}
else
{
    Console.WriteLine("Student ID Not Found");
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