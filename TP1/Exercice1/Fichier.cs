namespace TP1.Exercice1;


public class Fichier
{
    private string Nom;
    private string Extension;
    private float Taille; 
    
    // constructeur  
    public Fichier(string Nom, string Extension, float taille)
    {
        this.Nom = Nom;
        this.Extension = Extension;
        this.Taille = taille; 
    }

    public string getNom()
    {
        return Nom; 
    }

    public void setNom(string nom)
    {
        Nom = nom; 
    }
    public void setTaille(float tailleKO)
    {
        Taille = tailleKO; 
    }

    public float getTaille()
    {
        return Taille; 
    }
    public string getExtension()
    {
        return Extension; 
    }
    public Fichier(){}
}