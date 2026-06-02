using Data;
using Model;

namespace Logic;

public class FeedingSchedulesLog
{
    /*
     * Método que devuelve una lista de todos los horarios de alimentación
     * existentes en la base de datos.
     */
    public static List<FeedingSchedulesEntity> FeedingScheduleList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.FeedingSchedules.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo horario de alimentación en la base de datos.
     */
    public static void CreateFeedingSchedule(FeedingSchedulesEntity objFeedingSchedule)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo horario de alimentación al DbSet FeedingSchedules.
            db.FeedingSchedules.Add(objFeedingSchedule);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un horario de alimentación existente en la base de datos
     */
    public static void UpdateFeedingSchedule(FeedingSchedulesEntity objFeedingSchedule)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto horario de alimentación ha sido modificado.
            db.FeedingSchedules.Update(objFeedingSchedule);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}