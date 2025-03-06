namespace TP3;

public class Enseignant : Personnel
{
  public List<Groupe> listeGroupe = new List<Groupe>();
  public string grade;
  public double volumeHoraire;
  public double prime;
  public double heuresSup;
  public double heure; // combien le prof touche par heure 

  public override double calculerSalire()
  {
    return salaire + (heuresSup *heure) +prime; 
  }
}