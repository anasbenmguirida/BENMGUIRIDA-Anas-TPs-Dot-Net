namespace TP1.Exercice2;


public class Programmeur
{
    private int id;
    private string nom;
    private string prenom;
    private int bureau;
    public static int idGenerator =1;

    public Programmeur(){}
    public Programmeur( string nom, string prenom, int bureau)
    {
        this.id = idGenerator;
        idGenerator++; 
        this.nom = nom;
        this.prenom = prenom;
        this.bureau = bureau;
    }

    public int getId()
    {
        return this.id; 
    }

    public string getNom()
    {
        return nom; 
    }
    public string getPrenom()
    {
        return prenom; 
    }

    

    public override string ToString()
    {
        return id + "   | " + nom + " | " + prenom + " | " + bureau; 
    }
}