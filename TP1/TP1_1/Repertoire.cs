namespace TP1.Exercice1;

public class Repertoire
{
    private string Nom;
    private int nbrFichier; 
    private List<Fichier> listeFichier = new List<Fichier>(30); 
    
    // Constructeur 
    public Repertoire(string nom)
    {
        this.Nom = nom; 
    }
    // method pour supprimer un element d'un tableau 
    public void supprimerElement(){}
    
    // afficher 
    public void  Afficher()
    {
        Console.WriteLine("Nom du repertoire : " + this.Nom);
        int i = 1; 
        foreach (Fichier fichier in listeFichier)
        {
            
            Console.WriteLine("fichier numero   " + i + " : " + fichier.getNom() +"."+fichier.getExtension());
            i++; 
        }
    }

    public string Rechercher(string nomFichier)
    {
        foreach (Fichier fichier in listeFichier)
        {
            if (fichier.getNom() == nomFichier)
            {
                return "fichier trouve dans le repertoire " + nomFichier; 
                
            }
            
        }
        return "fichier non trouve dans ce repertoire "; 
    }
    
    // ajouter un fichier dans le repertoire 
    public void ajouter(Fichier fichier)
    {
        listeFichier.Add(fichier);
        this.nbrFichier++; 
       Console.WriteLine( "fichier ajouté et le nombre de fichier est  :  "+ nbrFichier); 
    }
    
    //rechercher que les pdfs 

    public void afficherPDFs()
    {
        foreach (Fichier fichier in listeFichier)
        {
            if (fichier.getExtension() =="pdf")
            {
                Console.WriteLine("les fichiers pdf : " + fichier.getNom() + "." + fichier.getExtension()); 
                
            }
            
        }
    }
    
    // supprimer par nom 
    public Boolean supprimer(string fileName)
    {
        foreach (Fichier fichier in listeFichier)
        {
            if (fichier.getNom() == fileName)
            {
                listeFichier.Remove(fichier);
                return true; 
            }
            
        }

        return false; 
    }
    
    // renomer un fichier 
    public void Renommer(Fichier file , string newFileName)
    {
        file.setNom(newFileName);
        Console.WriteLine("fichier renommé avec succes ! ");
    }
    
    // modifier la taille de fichier 
    public void Modifier(Fichier file, float tailleKO)
    {
        file.setTaille(tailleKO);
        Console.WriteLine("taille modifier avec succes ");
    }
    
    // taille en MO => somme dial ga3 les taille d files 
    public float getTaille()
    {
        float taille = 0f; 
        foreach (Fichier file in listeFichier)
        {
            taille += file.getTaille(); 
        }

        float tailleMO = taille / 1024;
        return tailleMO; 
    }

    /*static void Main(string[] args)
    {
        Repertoire repertoire = new Repertoire("TPs-C#");
        repertoire.ajouter(new Fichier("TP1", "cs", 1024)); 
        repertoire.ajouter(new Fichier("TP2", "cs", 1024)); 
        repertoire.ajouter(new Fichier("TP3", "pdf", 0));
        Console.WriteLine("la taille de repertoire en MO est : "+repertoire.getTaille()+"MO");
       

    }*/
    
    
}