using Data;
using Model;

namespace Logic;

public class SalesLog
{
   
    public static List<SalesEntity> SaleList()
    {
        using (var db = new DataContext())
        {
            return db.Sales.ToList();
        }
    }

   
    public static void CreateSale(SalesEntity objSale)
    {
        
        using (var db = new DataContext())
        {
           
            db.Sales.Add(objSale);
            db.SaveChanges();
        }
    }
    
    public static void UpdateSale(SalesEntity objSale)
    {
       
        using (var db = new DataContext())
        {
           
            db.Sales.Update(objSale);
            db.SaveChanges();
        }
    }
}