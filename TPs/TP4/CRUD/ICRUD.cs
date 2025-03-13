namespace TP4.CRUD;

public interface ICRUD<T>
{
   public void ajouter(T t);
   public void supprimer(int id);
   public void afficher();
   public T chercherParId(int id); 
}