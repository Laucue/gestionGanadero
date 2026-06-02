
using Data;
using Model;

namespace Logic;

public class ActivityLogLog
{
    
    public static List<ActivityLogEntity> AuditLogList()
    {
        
        using (var db = new DataContext())
        {
            
            return db.AuditLogs.ToList();
        }
    }

    public static void CreateAuditLog(ActivityLogEntity objAuditLog)
    {
        
        using (var db = new DataContext())
        {
           
            db.AuditLogs.Add(objAuditLog);
            db.SaveChanges();
        }
    }

    public static void UpdateAuditLog(ActivityLogEntity objAuditLog)
    {
        
        using (var db = new DataContext())
        {
            
            db.AuditLogs.Update(objAuditLog);
            db.SaveChanges();
        }
    }
}