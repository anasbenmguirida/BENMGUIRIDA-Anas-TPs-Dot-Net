namespace TP4.Config;
using MySql.Data.MySqlClient;
public class DatabaseConnection
{
    private static DatabaseConnection databaseConnection; 
     
    private DatabaseConnection(){}
    private static  MySqlConnection connection; 
    public static DatabaseConnection getInstance()
    {
        try
        {
             connection = new MySqlConnection("User Id=root;Host=localhost;Database=ensat");
            connection.Open();
            Console.WriteLine("heeere i connected to the database ");
            return new DatabaseConnection(); 
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public static MySqlConnection getConnection()
    {
        return connection; 
    }
}