namespace TP3;

public class Administrateur : Personnel
{
   
    public override double calculerSalire()
    {
        return salaire; 
    }

    public static void ajouterEtudiant(Etudiant etudiant , Enseignant enseignant , string nomGrp)
    {
        Groupe group = new Groupe(nomGrp);
       // group.getListeEtudiants().Add(etudiant);
        foreach (Groupe grp in enseignant.listeGroupe)
        {
            if (grp.nomGrp == nomGrp)
            {
                grp.getListeEtudiants().Add(etudiant);
                return;
            }
        }// si le programme arrive ici y3ni que ce groupe n'exite pas donc on le rajjoute
        List<Groupe> nouveauGrp =  enseignant.listeGroupe;
       group.getListeEtudiants().Add(etudiant);
       nouveauGrp.Add(group);
       
        
       
        Console.WriteLine("etudiant ajouter avec succes ");
        
    }
}