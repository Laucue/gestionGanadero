using Data;
using Model;

namespace Logic;

public class PastureTypesLog
{
    /*
     * Método que devuelve una lista de todas las especies
     * existentes en la base de datos.
     */
    public static List<PastureTypesEntity> SpeciesList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Species.ToList();
        }
    }

    /*
     * Método que permite crear una nueva especie en la base de datos.
     */
    public static void CreateSpecies(PastureTypesEntity objSpecies)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega la nueva especie al DbSet Species.
            db.Species.Add(objSpecies);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza una especie existente en la base de datos
     */
    public static void UpdateSpecies(PastureTypesEntity objSpecies)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto especie ha sido modificado.
            db.Species.Update(objSpecies);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}