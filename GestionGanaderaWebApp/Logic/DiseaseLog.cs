using Data;
using Model;

namespace Logic;

public class DiseasesLog
{
    public static List<DiseasesEntity> DiseaseList()
    {
        using var db = new DataContext();
        return db.Diseases.ToList();
    }

    public static void CreateDisease(DiseasesEntity obj)
    {
        using var db = new DataContext();
        db.Diseases.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateDisease(DiseasesEntity obj)
    {
        using var db = new DataContext();
        db.Diseases.Update(obj);
        db.SaveChanges();
    }
}
