namespace TP3;

public class Test
{
    public static void Main(string[] args)
    {
        Etudiant Etudiant1 = new Etudiant("m147852369" , "benmguirida" , "anas" , "GINF2" , 15.67);
        Etudiant Etudiant2 = new Etudiant("m12345879" , "benmguirida" , "anas" , "GINF2" , 15.67);
        Etudiant Etudiant3 = new Etudiant("m14700369" , "benmguirida" , "anas" , "GINF2" , 15.67);
        Etudiant Etudiant4 = new Etudiant("m1001129" , "benmguirida" , "anas" , "GINF2" , 15.67);
        Enseignant enseignant = new Enseignant("GHAILANI" , "Mohammed" , "m1234" , "PES" , 40.5 ,1500.0 , 5.0 , 400 ); 
        
        Administrateur.ajouterEtudiant(Etudiant1 ,enseignant ,  "GINF2");
        Administrateur.ajouterEtudiant(Etudiant2 ,enseignant ,  "GINF2");
        Administrateur.ajouterEtudiant(Etudiant3 , enseignant , "GINF2");
        Administrateur.ajouterEtudiant(Etudiant4 , enseignant , "GINF2");
        
        enseignant.afficherEnseignant();
        
    }
}