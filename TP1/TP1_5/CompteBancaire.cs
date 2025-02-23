namespace TP1.Exercice3;

public class CompteBancaire
{
    private string numCompte;
    private string nomClient;
    private string prenomClient;
    private string montant; 

    public CompteBancaire(string numCompte, string nomClient, string prenomClient , string montant)
    {
        this.numCompte = numCompte;
        this.nomClient = nomClient;
        this.prenomClient = prenomClient;
        this.montant = montant;
    }

    public static string chercherCompte(string numCompte)
    {
        string path = "C:\\Users\\anas\\Desktop\\TPs\\BENMGUIRIDA-Anas-TPs-Dot-Net\\TP1\\TP1_5\\Comptes.txt"; 
        foreach (string line in File.ReadLines(path))
        { 
            // Diviser la ligne en utilisant le séparateur '|'
            string[] fields = line.Split('|');
            // Extraire le nom d'utilisateur et le mot de passe
            string numeroCompte = fields[0].Trim();
            string nom = fields[1].Trim();
            string prenom = fields[2].Trim();
            string montant = fields[3].Trim();

            // Comparer avec les informations saisies
            if (numCompte == numeroCompte)
            {
                CompteBancaire compteBancaire = new CompteBancaire(numCompte, nom, prenom, montant);
               return numCompte + "-" + nom + " " + prenom +" - " +montant +"dhs" ;
            }
        }

        return "ce compte n'existe pas ! "; 
    }
    
    

    public string getNumCompte()
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

    public void setNumCompte(string num)
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
        return numCompte + " - " + nomClient + " " + prenomClient + " - " + montant;
    }
}