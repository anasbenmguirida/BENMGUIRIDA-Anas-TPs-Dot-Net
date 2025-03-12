using MySql.Data.MySqlClient;
using TP4.Config;
using TP4.Entities;

namespace TP4.Services;

public class EleveService
{
    private DatabaseConnection databaseConnection = DatabaseConnection.getInstance();
    private MySqlConnection db = DatabaseConnection.getConnection(); 
    


    public void getAllEleves()
    {
        MySqlCommand cmd = db.CreateCommand();
        cmd.Connection = db;
        cmd.CommandText = "SELECT *FROM eleves"; 
        MySqlDataReader dataReader = cmd.ExecuteReader();
        while(dataReader.Read())
            Console.WriteLine(dataReader.GetInt32(0)+" " + dataReader["nom"]+"  " + dataReader["prenom"]+" " + dataReader["groupe"]);
    }
    public void supprimerEleve(int id){}
    
    public void ajouterEleve(Eleve eleve)
    {
        
        MySqlCommand cmd = db.CreateCommand();
        cmd.Connection = db;
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
        eleveService.ajouterEleve(new Eleve("louah" , "mohamed","GINF2"));
        eleveService.getAllEleves();
    }
}