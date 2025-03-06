using System.Reflection.Emit;

namespace TP3;

public class Personne
{
    protected string code; 
    protected string nom;
    protected string prenom;

    public Personne(string code, string nom, string prenom)
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;
    }
    public Personne(){}
}