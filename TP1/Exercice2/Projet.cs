namespace TP1.Exercice2;

public class Projet
{
    private int code;
    private string sujet;
    private int duree;
    private int nbrProgrammeur;

    private List<Programmeur> listesProgrammeurs = new List<Programmeur>(); 
    private List<ConsomationCafee> listeConsomationCafees = new List<ConsomationCafee>(); 

    
    
   
    public Projet(int code, string sujet, int duree, int nbrProgrammeur)
    {
        this.code = code;
        this.sujet = sujet;
        this.duree = duree;
        this.nbrProgrammeur = nbrProgrammeur;
    }
    public Projet(){}

    public void ajouterProgrammeur(Programmeur programmeur)
    {
       listesProgrammeurs.Add(programmeur);
       Console.WriteLine("programmeur ajouté avec succes");
    }

    public Programmeur findByName(string name)
    {
        foreach (Programmeur p in listesProgrammeurs)
        {
            if (p.getNom() == name)
            {
                return p;
                break; 
            }
        }

        return null; 
    }

    public Programmeur findById(int id)
    {
        foreach (Programmeur programmeur in listesProgrammeurs)
        {
            if (programmeur.getId() == id)
            {
                return programmeur;
                break; 
            }
        }

        return null; 

    }
    public void supprimerProgrameur(string nomProgrammeur)
    {
        Programmeur programmeur = findByName(nomProgrammeur);
        if (programmeur != null)
        {
            listesProgrammeurs.Remove(programmeur);
        }
        else{Console.WriteLine("programmeur makaynch ");} 
    }
    public bool chercherProgrammeur(string nom)
    {
        bool check = false; 
        foreach (Programmeur programmeur in listesProgrammeurs)
        {
            if (programmeur.getNom() == nom)
            {
                Console.WriteLine("programmeur trouvé ");
                check = true; 
                break; 
            }
        }

        if (check == false)
        {
            Console.WriteLine("programmeur non trouvé ");
        }

        return check; 

    }

    public void afficherListeProgrammeurs()
    {
        foreach (Programmeur programmeur in listesProgrammeurs)
        {
            Console.WriteLine(programmeur.ToString()); 
        }
        
    }

    public void ajouterConsommation(int numSemaine , int programmerID , int nbrTasses)
    {
        // verifier l'existance de programmer 
        if (findById(programmerID) != null)
        {
            listeConsomationCafees.Add(new ConsomationCafee(numSemaine, programmerID, nbrTasses));
            Console.WriteLine("consomation ajouté   ");
        }
        else
        {
            Console.WriteLine("programmeur n'existe pas donc on peut pas ajouté une consomation ");
        }

        
    }


    static void Main(string[] args)
    {
        Projet projet = new Projet(); 
        projet.ajouterProgrammeur(new Programmeur("louah" , "mohamed" , 12));
        projet.ajouterProgrammeur(new Programmeur("benmguirida" , "anas" , 22));
        projet.afficherListeProgrammeurs();
        projet.ajouterConsommation(1 , 7 , 4);
        
    }



    

   
}