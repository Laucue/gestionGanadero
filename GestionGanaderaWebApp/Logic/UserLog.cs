using Data;
using Model;

namespace Logic;

public class UsersLog
{
  
    public static List<UsersEntity> UserList()
    {
    
        using (var db = new DataContext())
        {
            return db.Users.ToList();
        }
    }

    public static void CreateUser(UsersEntity objUser)
    {
       
        using (var db = new DataContext())
        {
            
            db.Users.Add(objUser);
            db.SaveChanges();
        }
    }

    public static void UpdateUser(UsersEntity objUser)
    {
        
        using (var db = new DataContext())
        {
           
            db.Users.Update(objUser);
           
            db.SaveChanges();
        }
    }
}