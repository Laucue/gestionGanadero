using Data;
using Model;

namespace Logic;

public class FeedingPlansLog
{
    /*
     * Método que devuelve una lista de todos los planes de alimentación
     * existentes en la base de datos.
     */
    public static List<FeedingPlansEntity> FeedingPlanList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.FeedingPlans.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo plan de alimentación en la base de datos.
     */
    public static void CreateFeedingPlan(FeedingPlansEntity objFeedingPlan)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo plan de alimentación al DbSet FeedingPlans.
            db.FeedingPlans.Add(objFeedingPlan);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un plan de alimentación existente en la base de datos
     */
    public static void UpdateFeedingPlan(FeedingPlansEntity objFeedingPlan)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto plan de alimentación ha sido modificado.
            db.FeedingPlans.Update(objFeedingPlan);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}

