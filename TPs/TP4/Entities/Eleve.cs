namespace TP4.Entities;

public class Eleve
{
    private int id;
    private string nom; 
    private string prenom;
    private string groupe;
    
    
    public Eleve( string nom, string prenom, string groupe)
    {
        
        this.nom = nom;
        this.prenom = prenom;
        this.groupe = groupe;
    }
   

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nom
    {
        get => nom;
        set => nom = value;
    }

    public string Prenom
    {
        get => prenom;
        set => prenom = value ;
    }

    public string Groupe
    {
        get => groupe;
        set => groupe = value ;
    }

    public override string ToString()
    {
        return nom + " " + prenom + " " + groupe; 
    }
}