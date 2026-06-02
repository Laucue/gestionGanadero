using Data;
using Model;

namespace Logic;

public class DietsLog
{
    /*
     * Método que devuelve una lista de todas las dietas
     * existentes en la base de datos.
     */
    public static List<DietsEntity> DietList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.Diets.ToList();
        }
    }

    /*
     * Método que permite crear una nueva dieta en la base de datos.
     */
    public static void CreateDiet(DietsEntity objDiet)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega la nueva dieta al DbSet Diets.
            db.Diets.Add(objDiet);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza una dieta existente en la base de datos
     */
    public static void UpdateDiet(DietsEntity objDiet)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto dieta ha sido modificado.
            db.Diets.Update(objDiet);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}
