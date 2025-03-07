namespace TP2.TP2_2;

public class Dictionnaire : Document
{
    private string langue;
    private int nombreMots;

    public Dictionnaire(string titre, string langue, int nombreMots) : base(titre)
    {
        this.langue = langue;
        this.nombreMots = nombreMots;
    }

    public override string ToString()
    {
        return titre + " | " + langue + " | " + nombreMots; ;
    }

    public override string descriprion()
    {
        return " DICTIONNAURE   : " + titre + " | " + langue + " | " + nombreMots;
    }
}