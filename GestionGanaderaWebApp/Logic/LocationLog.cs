using Data;
using Model;

namespace Logic;

public class LocationsLog
{
    /*
     * Método que devuelve una lista de todas las ubicaciones
     * existentes en la base de datos.
     */
    public static List<LocationsEntity> LocationList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Locations.ToList();
        }
    }

    /*
     * Método que permite crear una nueva ubicación en la base de datos.
     */
    public static void CreateLocation(LocationsEntity objLocation)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega la nueva ubicación al DbSet Locations.
            db.Locations.Add(objLocation);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza una ubicación existente en la base de datos
     */
    public static void UpdateLocation(LocationsEntity objLocation)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto ubicación ha sido modificado.
            db.Locations.Update(objLocation);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}