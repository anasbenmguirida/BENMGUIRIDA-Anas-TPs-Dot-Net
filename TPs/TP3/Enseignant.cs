namespace TP3;

public class Enseignant : Personnel
{
  public string grade;
  public double volumeHoraire;
  public double prime;
  public double heuresSup;

  public override double calculerSalire()
  {
    return 0.0; 
  }
}