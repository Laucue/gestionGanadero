using Data;
using Model;

namespace Logic;

public class DietItemsLog
{
    /*
     * Método que devuelve una lista de todos los items de dieta
     * existentes en la base de datos.
     */
    public static List<DietItemsEntity> DietItemList()
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se retorna todos los registros en una lista.
            return db.DietItems.ToList();
        }
    }

    /*
     * Método que permite crear un nuevo item de dieta en la base de datos.
     */
    public static void CreateDietItem(DietItemsEntity objDietItem)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se agrega el nuevo item de dieta al DbSet DietItems.
            db.DietItems.Add(objDietItem);
            // Se guardan los cambios en la base de datos.
            db.SaveChanges();
        }
    }

    /*
     * Método que actualiza un item de dieta existente en la base de datos
     */
    public static void UpdateDietItem(DietItemsEntity objDietItem)
    {
        /*
         * Se crea una nueva instancia del contexto de base de datos, lo cual asegura que los
         * recursos se liberen correctamente después de su uso.
         */
        using (var db = new DataContext())
        {
            // Se indica al contexto que el objeto item de dieta ha sido modificado.
            db.DietItems.Update(objDietItem);
            // Se guardan los cambios realizados en la base de datos.
            db.SaveChanges();
        }
    }
}