using System.Reflection.Emit;

namespace TP3;

public class Personne
{
    public string code; 
    public string nom;
    public string prenom;

    public Personne(string code, string nom, string prenom)
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;
    }
    public Personne(){}
}