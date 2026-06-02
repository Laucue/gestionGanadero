using Data;
using Model;

namespace Logic;

public class TreatmentsLog
{
    public static List<TreatmentsEntity> TreatmentList()
    {
        using var db = new DataContext();
        return db.Treatments.ToList();
    }

    public static void CreateTreatment(TreatmentsEntity obj)
    {
        using var db = new DataContext();
        db.Treatments.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateTreatment(TreatmentsEntity obj)
    {
        using var db = new DataContext();
        db.Treatments.Update(obj);
        db.SaveChanges();
    }
}
