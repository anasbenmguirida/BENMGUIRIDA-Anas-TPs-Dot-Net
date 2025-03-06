using System.Runtime.InteropServices.Marshalling;

namespace TP3;

public class Etudiant : Personne
{
    private double moyenne;
    private string niveau; 
    
    
    public Etudiant(string code , string nom , string prenom , string niveau, double moyenne):base(code ,  nom ,  prenom )
    {
        this.niveau = niveau;
        this.moyenne = moyenne;
    }
}