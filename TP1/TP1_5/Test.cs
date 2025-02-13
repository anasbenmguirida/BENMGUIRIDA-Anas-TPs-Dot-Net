namespace TP1.Exercice3;

public class Test
{
    static void Main()
    {
        // 9bl l'acces a l'app on doit verifier l'identifiant et le mot de passe 
        
        
        Console.WriteLine("=================================");
        Console.WriteLine("1) ajouter un compte ");
        Console.WriteLine("2) recherche d'un compte ");
        Console.WriteLine("3) supprimer un compte");
        Console.WriteLine("4) operation sur un compte ");
        Console.WriteLine("5) afficher tous les comptes");
        Console.WriteLine("6) quitter le programme");
        Console.WriteLine("=================================");
        Console.WriteLine("choisiser un numero ! ");
        string userInputString = Console.ReadLine();
        int userInput =  int.Parse(userInputString); 
        switch (userInput)
        {
            case 1 :
                Console.WriteLine("vous avez choisi d'ajouter un compte ! "); 
                Console.WriteLine("entrer le numero de Compte : ");
                string numCompteString = Console.ReadLine();
                int numCompte = int.Parse(numCompteString); 
                Console.WriteLine("entrer le nom de client  : ");
                string nomClient = Console.ReadLine(); 
                Console.WriteLine("entrer le prenom de client  : ");
                string prenomClient = Console.ReadLine();
                CompteBancaire compteBancaire = new CompteBancaire(numCompte, nomClient, prenomClient);
                Console.WriteLine("traitement en cours .........");
                // insertion dans un fichier text 
                string path = "C:\\Users\\anas\\Desktop\\Tps-dotnet\\TP1\\Exercice3\\Comptes.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("\n");
                    sw.WriteLine(compteBancaire.ToString());
                }
                Console.WriteLine("Compte crée");
                break;
            default:
                Console.WriteLine("mazal masawbna hadchi ");
                break;
                
                
                
        }
    }
}