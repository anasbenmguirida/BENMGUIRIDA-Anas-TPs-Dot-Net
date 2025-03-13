using MySql.Data.MySqlClient;
using TP4.Config;
using TP4.Entities;
using TP4.CRUD;


namespace TP4.Services;

public class EleveService : ICRUD<Eleve>
{
    private DatabaseConnection databaseConnection = DatabaseConnection.getInstance();
    private MySqlConnection db;
    private MySqlCommand cmd;
    private MySqlDataReader dataReader; 
    public EleveService()
    {
        db = DatabaseConnection.getConnection();
        cmd = db.CreateCommand();
        cmd.Connection = db;
       
    }

    public void afficher()
    {
        cmd.CommandText = "SELECT *FROM eleves";
        dataReader = cmd.ExecuteReader();
        while(dataReader.Read())
            Console.WriteLine(dataReader.GetInt32(0)+" " + dataReader["nom"]+"  " + dataReader["prenom"]+" " + dataReader["groupe"]);
        dataReader.Close();
    }

    public Eleve chercherParId(int id)
    {
        
        cmd.CommandText = "SELECT *FROM eleves WHERE id = @id";
        cmd.Parameters.AddWithValue("@id", id); 
        dataReader = cmd.ExecuteReader();
        if (dataReader.Read())
        {
            Console.WriteLine(dataReader["nom"].GetType());
           Eleve eleve = new Eleve(dataReader.GetString("nom"), dataReader.GetString("prenom"),
                dataReader.GetString("groupe"));
           dataReader.Close();
           return eleve; 
        }

        return null; 
    }

    public void supprimer(int id)
    {
        if (chercherParId(id) != null)
        {
            cmd.CommandText = "delete from eleves where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Console.WriteLine("eleve supprimé avec succes ");
        }
        else
        {
            Console.WriteLine("eleve n'existe pas"); 
        }



    }
    
    public void ajouter(Eleve eleve)
    {
        try
        {
            cmd.CommandText = "INSERT INTO eleves (nom, prenom, groupe) VALUES (@nom, @prenom, @groupe)";
            // Ajout des paramètres car on peut les ecrires directement dans la commande , ils sont interprete comme des noms des colonnes
            cmd.Parameters.AddWithValue("@nom", eleve.Nom);
            cmd.Parameters.AddWithValue("@prenom", eleve.Prenom);
            cmd.Parameters.AddWithValue("@groupe", eleve.Groupe);
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public static void Main(string[] args)
    {
        EleveService eleveService = new EleveService();
        
    }
}