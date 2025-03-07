namespace TP3;

public class Enseignant : Personnel
{
  public  List<Groupe> listeGroupe = new List<Groupe>();
  public string grade;
  public double volumeHoraire;
  public double prime;
  public double heuresSup = 0 ;
  public double heure; // combien le prof touche par heure ca depand du grade du prof

  public Enseignant(string n , string p , string c , string grade, double volumeHoraire, double prime, double heuresSup, double heure)
  {
    nom = n;
    prenom = p;
    code = c;
    this.grade = grade;
    this.volumeHoraire = volumeHoraire;
    this.prime = prime;
    this.heuresSup = heuresSup;
    this.heure = heure;
  }

  

  public override double calculerSalire()
  {
    return salaire + (heuresSup *heure) +prime; 
  }

  public void afficherEnseignant()
  {
    Console.WriteLine(" " + nom  + " " + prenom + " " + grade);
    foreach (Groupe groupe in listeGroupe)
    {
      Console.WriteLine("****************** " + groupe.nomGrp  + " *********************");
      foreach (Etudiant etu in groupe.getListeEtudiants())
      {
       etu.afficherEtudiant();
      }
    }
  }
}