using Data;
using Model;

namespace Logic;

public class BreedsLog
{
    /*
     * Método que devuelve una lista de todas las razas
     * existentes en la base de datos.
     */
    public static List<BreedsEntity> BreedList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Breeds.ToList();
        }
    }

    /*
     * Método que permite crear una nueva raza en la base de datos.
     */
    public static void CreateBreed(BreedsEntity objBreed)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega la nueva raza al DbSet Breeds.
            db.Breeds.Add(objBreed);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza una raza existente en la base de datos
     */
    public static void UpdateBreed(BreedsEntity objBreed)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto raza ha sido modificado.
            db.Breeds.Update(objBreed);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}