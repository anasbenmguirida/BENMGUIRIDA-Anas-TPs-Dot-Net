namespace TP2.TP2_1;

public class Test
{
    public static void Main(string[] args)
    {
        GestionEmployes gestion = new GestionEmployes();
        gestion.ajouterEmployee(new Employee("benmguirida", "anas", 8000, "developpeur java", DateTime.Now));
        gestion.ajouterEmployee(new Employee("louah", "mohamed", 8000, "testeur", DateTime.Now));
        gestion.ajouterEmployee(new Employee("al azzami", "tarek", 8000, "developpeur nextjs", DateTime.Now));

        
        Directeur directeur = Directeur.GetInstance();
        Directeur.setGestionEmployes(gestion);
        Console.WriteLine(" le salaire moyen de l'enterprise est : " + Directeur.getSalaireMoyen()); 
        Console.WriteLine("le salaire totale de l'entreprise est : " + Directeur.getSalaireTotal());
        
    }

}