using Data;
using Model;

namespace Logic;

public class VaccinesLog
{
    /*
     * Método que devuelve una lista de todas las vacunas
     * existentes en la base de datos.
     */
    public static List<VaccinesEntity> VaccineList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Vaccines.ToList();
        }
    }

    /*
     * Método que permite crear una nueva vacuna en la base de datos.
     */
    public static void CreateVaccine(VaccinesEntity objVaccine)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega la nueva vacuna al DbSet Vaccines.
            db.Vaccines.Add(objVaccine);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza una vacuna existente en la base de datos
     */
    public static void UpdateVaccine(VaccinesEntity objVaccine)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto vacuna ha sido modificado.
            db.Vaccines.Update(objVaccine);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}

