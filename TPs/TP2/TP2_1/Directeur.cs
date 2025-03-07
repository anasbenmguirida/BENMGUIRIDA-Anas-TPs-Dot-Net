namespace TP2.TP2_1;

public class Directeur
{
    private static Directeur directeurInstance;
    
    public static GestionEmployes gestionEmployes = new GestionEmployes(); 
    private Directeur(){}

    public static Directeur GetInstance()
    {
        if (directeurInstance == null)
        {
            return new Directeur(); 
        }
        return directeurInstance;
    }

    public static double getSalaireMoyen()
    {
       return gestionEmployes.salaireMoyen(); 
    }

    public static double getSalaireTotal()
    {
        return gestionEmployes.calculerSalaireTotal(); 
    }

    public static void setGestionEmployes(GestionEmployes gestion)
    {
        gestionEmployes = gestion;
    }
}