namespace TP3;

public class Directeur : Personnel // singleton 
{
    private double prime; 
    public override double calculerSalire()
    {
        return salaire + prime; 
    }

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