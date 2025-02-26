namespace TP1.Exercice3;

public class CompteBancaire
{
    private string numCompte;
    private string nomClient;
    private string prenomClient;
    private string montant; 

  public CompteBancaire(){} 
    public CompteBancaire(string numCompte, string nomClient, string prenomClient , string montant)
    {
        this.numCompte = numCompte;
        this.nomClient = nomClient;
        this.prenomClient = prenomClient;
        this.montant = montant;
    }

    public static CompteBancaire chercherCompte(string numCompte)
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
                return compteBancaire; 
               
            }
        }

        return null; 
    }

    public static void modifierMontant(string montant, string numCompte)
    {
        string path = "C:\\Users\\anas\\Desktop\\TPs\\BENMGUIRIDA-Anas-TPs-Dot-Net\\TP1\\TP1_5\\Comptes.txt";
        List<string> lines = File.ReadAllLines(path).ToList(); // Lire toutes les lignes 

        bool found = false;

        for (int i = 0; i < lines.Count; i++)
        {
            string[] fields = lines[i].Split('|');
            if (fields[0].Trim() == numCompte)
            {
                fields[3] = montant; // Modifier le montant (supposons qu'il est à l'index 1)
                lines[i] = string.Join("|", fields); // Reconstruire la ligne
                found = true;
                break;
            }
        }

        if (found)
        {
            File.WriteAllLines(path, lines); // Réécrire le fichier avec les modifications
            Console.WriteLine("Montant modifié avec succès !");
        }
        else
        {
            Console.WriteLine("Compte non trouvé !");
        }

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

    public string getMontant()
    {
        return montant;
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