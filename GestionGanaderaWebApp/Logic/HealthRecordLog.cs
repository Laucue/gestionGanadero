using Data;
using Model;

namespace Logic;

public class HealthRecordsLog
{
    /*
     * Método que devuelve una lista de todos los registros de salud
     * existentes en la base de datos.
     */
    public static List<HealthRecordsEntity> HealthRecordList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.HealthRecords.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo registro de salud en la base de datos.
     */
    public static void CreateHealthRecord(HealthRecordsEntity objHealthRecord)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo registro de salud al DbSet HealthRecords.
            db.HealthRecords.Add(objHealthRecord);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un registro de salud existente en la base de datos
     */
    public static void UpdateHealthRecord(HealthRecordsEntity objHealthRecord)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto registro de salud ha sido modificado.
            db.HealthRecords.Update(objHealthRecord);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}

