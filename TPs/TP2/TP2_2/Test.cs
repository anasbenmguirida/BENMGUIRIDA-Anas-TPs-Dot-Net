namespace TP2.TP2_2;

public class Test
{


    public static void Main(string[] args)
    {
        Biblio biblio = new Biblio();
        Document livre = new Livre("C# fundalentals", "anas", 152); 
        Document livre2 = new Livre("java fundalentals", "mohamed", 200);
        Document dictionnaire = new Dictionnaire("larouse", "francais", 1024); 
        Document dictionnaire2 = new Dictionnaire("engdict", "anglais", 500); 
        
        biblio.ajouterDocument(livre);
        biblio.ajouterDocument(livre2);
        biblio.ajouterDocument(dictionnaire);
        biblio.ajouterDocument(dictionnaire2);
        
        biblio.afficherDictionnaire();
        
        biblio.tousLesAuteurs();
        
        biblio.toutLesDescriptions();
        
    }
}