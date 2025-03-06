namespace TP3;

public class ResourcesHumaines : IResourcesHumaines
{
    private List<Enseignant> listEnseignants = new List<Enseignant>();
    public string afficherEnseignant(string code)
    {
        Enseignant enseignant = rechercherEnseignant(code);
        if (enseignant != null)
        {
            return enseignant.nom + " | " + enseignant.prenom + " | " + enseignant.grade;
        }
        return "professeur n'existe pas ";
    }

    public Enseignant rechercherEnseignant(string code)
    {
        foreach (Enseignant ens in listEnseignants)
        {
            if (ens.code == code)
            {
                return ens;
                break; 
            }
        } 
        return null;
    }
}