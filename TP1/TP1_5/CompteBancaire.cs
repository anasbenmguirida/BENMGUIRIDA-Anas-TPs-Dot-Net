namespace TP1.Exercice3;

public class CompteBancaire
{
    private int numCompte;
    private string nomClient;
    private string prenomClient;

    public CompteBancaire(int numCompte, string nomClient, string prenomClient)
    {
        this.numCompte = numCompte;
        this.nomClient = nomClient;
        this.prenomClient = prenomClient;
    }
    

    public int getNumCompte()
    {
        return numCompte; 
    }

    public string getNomClient()
    {
        return nomClient; 
    }

    public string getPrenomClient()
    {
        return prenomClient; 
    }

    public void setNumCompte(int num)
    {
        numCompte = num; 
    }
    public void setNomClient(string nom)
    {
        nomClient = nom; 
    }
    public void setNPrenomClient(string prenom)
    {
        prenomClient = prenom; 
    }

    public string ToString()
    {
        return numCompte + " | " + nomClient + " | " + prenomClient;
    }
}