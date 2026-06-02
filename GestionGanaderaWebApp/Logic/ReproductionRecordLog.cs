using Data;
using Model;

namespace Logic;

public class BreedingRecordsLog
{
    /*
     * Método que devuelve una lista de todos los registros de reproducción
     * existentes en la base de datos.
     */
    public static List<BreedingRecordsEntity> ReproductionRecordList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.ReproductionRecords.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo registro de reproducción en la base de datos.
     */
    public static void CreateReproductionRecord(BreedingRecordsEntity objReproductionRecord)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo registro de reproducción al DbSet ReproductionRecords.
            db.ReproductionRecords.Add(objReproductionRecord);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un registro de reproducción existente en la base de datos
     */
    public static void UpdateReproductionRecord(BreedingRecordsEntity objReproductionRecord)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto registro de reproducción ha sido modificado.
            db.ReproductionRecords.Update(objReproductionRecord);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}
