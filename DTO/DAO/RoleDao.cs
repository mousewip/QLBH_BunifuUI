using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DAO
{
    public class RoleDao
    {
        private static RoleDao _instance;

        public static RoleDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoleDao();
                }
                return _instance;
            }
        }

        private RoleDao() { }

        public List<Role> View()
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Roles.Select(x => x).ToList();
            }
        }


    }
}
