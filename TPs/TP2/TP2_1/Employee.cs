namespace TP2.TP2_1;

public class Employee
{
    private string nom ;
    private string prenom ;
    private double salaire;
    private string poste; 
    private DateTime dateEmbauche;


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

    public double Salaire
    {
        get => salaire;
        set => salaire = value;
    }

    public string Poste
    {
        get => poste;
        set => poste = value;
    }

    public DateTime DateEmbauche
    {
        get => dateEmbauche;
        set => dateEmbauche = value;
    }

    public Employee(string nom, string prenom, double salaire, string poste, DateTime dateEmbauche)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.salaire = salaire;
        this.poste = poste;
        this.dateEmbauche = dateEmbauche;
    }
}