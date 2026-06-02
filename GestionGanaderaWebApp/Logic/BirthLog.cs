using Data;
using Model;

namespace Logic;

public class BirthsLog
{
    public static List<BirthsEntity> BirthList()
    {
        using var db = new DataContext();
        return db.Births.ToList();
    }

    public static void CreateBirth(BirthsEntity obj)
    {
        using var db = new DataContext();
        db.Births.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateBirth(BirthsEntity obj)
    {
        using var db = new DataContext();
        db.Births.Update(obj);
        db.SaveChanges();
    }
}
