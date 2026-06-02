using Data;
using Model;

namespace Logic;

public class SaleDetailsLog
{
    public static List<SaleDetailsEntity> SaleDetailList()
    {
        using var db = new DataContext();
        return db.SaleDetails.ToList();
    }

    public static void CreateSaleDetail(SaleDetailsEntity obj)
    {
        using var db = new DataContext();
        db.SaleDetails.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateSaleDetail(SaleDetailsEntity obj)
    {
        using var db = new DataContext();
        db.SaleDetails.Update(obj);
        db.SaveChanges();
    }
}
