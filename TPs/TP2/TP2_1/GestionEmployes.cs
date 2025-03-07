namespace TP2.TP2_1;

public class GestionEmployes
{
    public List<Employee> listeEmployees = new List<Employee>();
    
    
    public GestionEmployes(){}

    public void ajouterEmployee(Employee employee)
    {
        listeEmployees.Add(employee);
        Console.WriteLine("employee ajouter ");
    }

    public void suppeimerEmployee(string nom)
    {
        foreach (Employee emp in listeEmployees)
        {
            if (emp.Nom == nom)
            {
                listeEmployees.Remove(emp);
                Console.WriteLine("employee suppeimer ");
                return;
            }
            
        }
        Console.WriteLine("employee n'existe pas  ");
    }

    public double calculerSalaireTotal()
    {
        double salaireTotal = 0;
        foreach (Employee emp  in listeEmployees)
        {
            salaireTotal +=emp.Salaire;
        }
        return salaireTotal;
    }

    public double salaireMoyen()
    {
        double salaireMoyen = calculerSalaireTotal();
        return salaireMoyen/listeEmployees.Count;
    }
}