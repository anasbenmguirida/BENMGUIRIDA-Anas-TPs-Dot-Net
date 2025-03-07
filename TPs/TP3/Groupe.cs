namespace TP3;

public class Groupe
{
    public string nomGrp; 
    private List<Etudiant> listeEtudiants = new List<Etudiant>();
    public Groupe(){}

    public Groupe(string Groupe)
    {
        this.nomGrp = nomGrp; 
    }


    public List<Etudiant> getListeEtudiants()
    {
        return listeEtudiants;
    }
}