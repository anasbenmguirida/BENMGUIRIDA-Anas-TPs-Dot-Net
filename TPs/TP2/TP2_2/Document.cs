namespace TP2.TP2_2;

public abstract class Document
{
    public static int numeroDocument = 0 ;
    public string titre;
    public int numero;

    public Document(string titre)
    {
        this.titre = titre;
       numero = ++numeroDocument;
    }
    
    public abstract string descriprion();
}