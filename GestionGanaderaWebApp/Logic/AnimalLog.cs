using Data;
using Model;

namespace Logic;

public class AnimalsLog
{
    /*
     * Método que devuelve una lista de todos los animales
     * existentes en la base de datos.
     */
    public static List<AnimalsEntity> AnimalList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Animals.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo animal en la base de datos.
     */
    public static void CreateAnimal(AnimalsEntity objAnimal)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo animal al DbSet Animals.
            db.Animals.Add(objAnimal);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un animal existente en la base de datos
     */
    public static void UpdateAnimal(AnimalsEntity objAnimal)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto animal ha sido modificado.
            db.Animals.Update(objAnimal);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}

