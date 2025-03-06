namespace TP3;

public class Directeur // singleton 
{
    private static Directeur instance; 
    private Directeur(){}

    public static Directeur getInstance()
    {
        if (instance == null)
        {
            return new Directeur(); 
        }
        return instance;
    }
}