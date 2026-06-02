using Data;
using Model;

namespace Logic;

public class MedicalCheckupsLog
{
    public static List<MedicalCheckupsEntity> MedicalCheckupList()
    {
        using var db = new DataContext();
        return db.MedicalCheckups.ToList();
    }

    public static void CreateMedicalCheckup(MedicalCheckupsEntity obj)
    {
        using var db = new DataContext();
        db.MedicalCheckups.Add(obj);
        db.SaveChanges();
    }

    public static void UpdateMedicalCheckup(MedicalCheckupsEntity obj)
    {
        using var db = new DataContext();
        db.MedicalCheckups.Update(obj);
        db.SaveChanges();
    }
}
