using BCrypt.Net;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;


class DBConnect {
    public MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructor
    public DBConnect() {
        Initialize();
    }

    //Initialize values
    public void Initialize() {
        server = "138.197.128.70";
        database = "licensing";
        uid = "hayden";
        password = "loliown123!";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
    }

    public void InsertUser(string email, string password, string hwid) {
        connection.Open();
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO users(email, password, hwid) VALUES (@email, @password, @hwid)";
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@password", passwordHash);
        command.Parameters.AddWithValue("@hwid", hwid);

        IDataReader reader = command.ExecuteReader();

        if (reader.Read()) {
            Debug.WriteLine(reader);
        }

        connection.Close();

    }
}