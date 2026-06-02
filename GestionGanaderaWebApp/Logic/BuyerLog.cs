using Data;
using Model;

namespace Logic;

public class BuyersLog
{
    public static List<BuyersEntity> BuyerList()
    {
        using var db = new DataContext();
        return db.Buyers.ToList();
    }

    public static void CreateBuyer(BuyersEntity obj)
    {
        using var db = new DataContext();
        db.Buyers.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateBuyer(BuyersEntity obj)
    {
        using var db = new DataContext();
        db.Buyers.Update(obj);
        db.SaveChanges();
    }
}
