namespace TP1.Exercice3;
using System.Collections.Generic;
using Newtonsoft.Json ; 
using System.IO;

public class Auth
{

    public static bool estAuthentifié(string identiiant, string password)
    {
        string jsonFile = "identifiant.json";
        string jsonData = File.ReadAllText(jsonFile);
        List<Utilisateur> utilisateurs = JsonConvert.DeserializeObject<List<Utilisateur>>(jsonData);
    }
}