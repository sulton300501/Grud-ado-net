using Npgsql;
class Program
{
    static void Main()
    {
        // Read();
        /*Update();*/
        /*Update();*/
        Delete();
    }



    static void Create()
    {
        string connectionString = "Host=localhost;Port=5432;Database=ulash;User Id=postgres;Password=sulton;";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();

        string query = "insert into TestTable(name) values('Sulton')";
        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

        cmd.ExecuteNonQuery();
    }

    static void Read()
    {
        string connectionString = "Host=localhost;Port=5432;Database=ulash;User Id=postgres;Password=sulton;";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();

        string query = "select * from TestTable";
        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
        using NpgsqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"name:{reader["name"]}");

        }
            


    }

    static void Update()
    {
        string connectionString = "Host=localhost;Port=5432;Database=ulash;User Id=postgres;Password=sulton;";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();

        string query = "update  TestTable set name='Karim' where name='Akmal'";
        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
       
        int rowsAffect = cmd.ExecuteNonQuery() ;
        Console.WriteLine($"{rowsAffect} updated" );

      


    }
    static void Delete()
    {
        string connectionString = "Host=localhost;Port=5432;Database=ulash;User Id=postgres;Password=sulton;";

        using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();

        string query = "DELETE FROM TestTable WHERE  name='Karim'";
        using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

        int rowsAffectname = cmd.ExecuteNonQuery();
        Console.WriteLine($"{rowsAffectname} deleted...");


    }






}