using Data;
using Model;

namespace Logic;

public class RolesLog
{
    
    public static List<RolesEntity> RoleList()
    {
        
        using (var db = new DataContext())
        {
          
            return db.Roles.ToList();
        }
    }
    
    public static void CreateRole(RolesEntity objRole)
    {
        
        using (var db = new DataContext())
        {
            
            db.Roles.Add(objRole);
            db.SaveChanges();
        }
    }

    public static void UpdateRole(RolesEntity objRole)
    {
       
        using (var db = new DataContext())
        {
            
            db.Roles.Update(objRole);
            db.SaveChanges();
        }
    }
}