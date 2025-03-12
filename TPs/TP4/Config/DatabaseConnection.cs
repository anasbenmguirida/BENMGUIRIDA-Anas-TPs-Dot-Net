namespace TP4.Config;
using MySql.Data.MySqlClient;
public class DatabaseConnection
{
    private static DatabaseConnection databaseConnection; 
     
    private DatabaseConnection(){}
    private static  MySqlConnection conn; 
    public static DatabaseConnection getInstance()
    {
        try
        {
             conn = new MySqlConnection("User Id=root;Host=localhost;Database=ensat");
            conn.Open();
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
        return conn; 
    }
}