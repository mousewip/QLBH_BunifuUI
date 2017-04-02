using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Model;

namespace DTO.DAO
{
    public class UserDao
    {
        private static UserDao _instance;

        public static UserDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserDao();
                }
                return _instance;
            }
        }
        
        private UserDao(){}

        public List<User> View()
        {
            List<User> lnv;

            using (var db = new ShopTPTDataContext())
            {
                lnv = db.Users.Select(x => x).ToList();
            }
            return lnv;
        }

        public bool Update(int maNv, User nv)
        {
            using (var db = new ShopTPTDataContext())
            {
                var user = db.Users.SingleOrDefault(x => x.UserID == maNv);
                if (user != null)
                {
                    user.UserID = nv.UserID;
                    user.Address = nv.Address;
                    user.DayOfBirth = nv.DayOfBirth;
                    user.Email = nv.Email;
                    user.Gender = nv.Gender;
                    user.Password = Helper.Md5Encrypt(nv.Password);
                    user.Phone = nv.Phone;
                    user.FullName = nv.FullName;
                    user.RoleID = nv.RoleID;
                }

                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }

        public bool Add(User nv)
        {
            using (var db = new ShopTPTDataContext())
            {
                db.Users.InsertOnSubmit(nv);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    
                    //
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            using (var db = new ShopTPTDataContext())
            {
                var user = db.Users.SingleOrDefault(x => x.UserID == id);
                if (user != null) db.Users.DeleteOnSubmit(user);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
                
            }
        }


        public User FindSingleUser(string userName, string password)
        {
            using (var db = new ShopTPTDataContext())
            {
                var user = db.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
                return user;
            }
        }

        public List<User> FindUser(string strFind)
        {
            int userId;
            try
            {
                userId = int.Parse(strFind);
            }
            catch (Exception)
            {
                userId = 0;
            }

            List<User> lUser;
            using (var db = new ShopTPTDataContext())
            {
                lUser =
                    db.Users.Select(x => x)
                        .Where(p => p.UserID == userId || p.FullName.Contains(strFind) || p.UserName.Contains(strFind)).ToList();
            }
            return lUser;
        }

        public User SelectSingleUserById(int id)
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Users.SingleOrDefault(x => x.UserID == id);
            }
        }
    }
}
