namespace TP2.TP2_2;

public class Livre :Document
{
    private string auteur;

    public string Auteur
    {
        get => auteur;
        set => auteur = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NombrePage
    {
        get => nombrePage;
        set => nombrePage = value;
    }

    private int nombrePage;


    public Livre(string titre, string auteur, int nombrePage) : base(titre)
    {
        this.auteur = auteur;
        this.nombrePage = nombrePage;
    }

    public override string descriprion()
    {
       return "LIVRE  : "  + titre +" | " +  auteur + " | " + nombrePage;
    }
}