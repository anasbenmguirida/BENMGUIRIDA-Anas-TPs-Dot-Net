namespace TP1.Exercice3;

public class Test
{
    static void Main()
    {
        bool checkCredentidals = false; 
        // 9bl l'acces a l'app on doit verifier l'identifiant et le mot de passe 3 tentatif maximum 
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("tentatif numero  : " + i);
            Console.WriteLine("Veuillez entrer votre identifiant : ");
            string identifiant  = Console.ReadLine();
            Console.WriteLine("Veuillez entrer votre mot de passe :");
            string password  = Console.ReadLine();
            if (Auth.estAuthentifié(identifiant, password))
            {
                checkCredentidals = true; 
                break;
            }
            else
            {
                Console.WriteLine("Erreur  , il vous reste  ", i + 1, "tentatives");
            }

        }
        if (checkCredentidals)
        {


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
            int userInput = int.Parse(userInputString);
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("vous avez choisi d'ajouter un compte ! ");
                    Console.WriteLine("entrer le numero de Compte : ");
                    string numCompte = Console.ReadLine();
                    
                    Console.WriteLine("entrer le nom de client  : ");
                    string nomClient = Console.ReadLine();
                    Console.WriteLine("entrer le prenom de client  : ");
                    string prenomClient = Console.ReadLine();
                    CompteBancaire compteBancaire = new CompteBancaire(numCompte, nomClient, prenomClient,"0");
                    Console.WriteLine("traitement en cours .........");
                    // insertion dans un fichier text 
                    string path = "C:\\Users\\anas\\Desktop\\TPs\\BENMGUIRIDA-Anas-TPs-Dot-Net\\TP1\\TP1_5\\Comptes.txt";
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("\n");
                        sw.WriteLine(compteBancaire.ToString());
                    }

                    Console.WriteLine("Compte crée");
                    break;
                
                case 2 : 
                    // recherche d'un compte par son numero 
                     Console.WriteLine("veullez saisir le numero de compte : ");
                     string num = Console.ReadLine();
                    Console.WriteLine(CompteBancaire.chercherCompte(num));
                    break; 
                case 4 : 
                    Console.WriteLine("veullez entrer votre numero de compte : ");
                    string numCpt = Console.ReadLine();
                    CompteBancaire.chercherCompte(numCpt);
                    Console.WriteLine("=================================");
                    Console.WriteLine("1) Crediter ");
                    Console.WriteLine("2) Debiter ");
                    Console.WriteLine("3) Historique");
                    Console.WriteLine("4) Transfert d'argent ");
                    Console.WriteLine("5) Revenir au menue principal ");
                    Console.WriteLine("=====================================");
                    Console.WriteLine("sasisez votre choix  ! ");
                    int choix = int.Parse(Console.ReadLine());
                    break; 
                    
                default:
                    Console.WriteLine("mazal masawbna hadchi ");
                    break;



            }
        }
        else
        {
            Console.WriteLine("tentatives max  : identifiant ou mot de passe invalide ");
        }
    }
}