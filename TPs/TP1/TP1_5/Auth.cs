using Newtonsoft.Json;

namespace TP1.Exercice3;
using System.Collections.Generic;

using System.IO;

public class Auth
{

    public static bool estAuthentifié(string identiiant, string password)
    {
        string jsonFile = "C:\\Users\\anas\\Desktop\\TPs\\BENMGUIRIDA-Anas-TPs-Dot-Net\\TP1\\TP1_5\\identifiant.json";
        string jsonData = File.ReadAllText(jsonFile);
        List<Utilisateur> utilisateurs = JsonConvert.DeserializeObject<List<Utilisateur>>(jsonData);
        Utilisateur utilisateur = utilisateurs?.FirstOrDefault(u => u.id == identiiant && u.password == password);
        return utilisateur != null ? true : false; 
    }
}