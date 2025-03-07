namespace TP2.TP2_2;

public class Biblio
{
    public List<Document> documents = new List<Document>();

    public Biblio(){}
    public void ajouterDocument(Document document)
    {
        documents.Add(document);
        
    }

    public int getNombreLivre()
    {
        int nombreLivre = 0;
        foreach (Document doc in documents)
        {
            if (doc is Livre)
            {
                nombreLivre++;
            }
        }
        return nombreLivre;
    }

    public void afficherDictionnaire()
    {
        Console.WriteLine("******************** dictionnaires *********************");
        foreach (Document doc in documents)
        {
            if (doc is Dictionnaire)
            {
                Console.WriteLine(doc.ToString());
            }
        }
        
    }
    
    public void tousLesAuteurs()
    {
        Dictionary<int , string> numeroEtAuteurs = new Dictionary<int , string>();
        foreach (Document doc in documents)
        {
            if (doc is Livre)
            {
                Livre livre = (Livre)doc; 
                numeroEtAuteurs.Add(doc.numero , livre.Auteur);
            }
        }
        Console.WriteLine("liste des numeros et auteurs:");
        int i = 0;
        while (i<numeroEtAuteurs.Count)
        {
            
            Console.WriteLine(numeroEtAuteurs.ElementAt(i));
            i++; 
        }
    }

    public void toutLesDescriptions()
    {
        foreach (Document doc in documents)
        {
            Console.WriteLine(doc.descriprion()); 
        }
    }
}