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
                var user = db.Users.SingleOrDefault(x => x.UserCode == maNv);
                if (user != null)
                {
                    user.UserCode = nv.UserCode;
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

        public void Delete(int id)
        {
            using (var db = new ShopTPTDataContext())
            {
                var user = db.Users.SingleOrDefault(x => x.UserCode == id);
                if (user != null) db.Users.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
        }


        public int FindSingleUser(string userName, string password)
        {
            using (var db = new ShopTPTDataContext())
            {
                var user = db.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
                if (user != null)
                {
                    return user.UserCode;
                }
            }
            return 0;
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
                        .Where(p => p.UserCode == userId || p.FullName.Contains(strFind) || p.UserName.Contains(strFind)).ToList();
            }
            return lUser;
        }

        public User SelectSingleUserById(string id)
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Users.SingleOrDefault(x => x.UserCode == int.Parse(id));
            }
        }
    }
}
