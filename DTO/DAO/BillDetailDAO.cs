using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Model;

namespace DTO.DAO
{
    public class BillDetailDAO
    {
        private static BillDetailDAO _instance;

        public static BillDetailDAO Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new BillDetailDAO();
                return _instance;
            }
        }

        private BillDetailDAO() { }

        public List<BillDetail> View()
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.BillDetails.Select(x => x).ToList();
            }
        }

        public bool Add(BillDetail billDetail)
        {
            using (var db = new ShopTPTDataContext())
            {
                db.BillDetails.InsertOnSubmit(billDetail);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(int bID, int pID)
        {
            using (var db = new ShopTPTDataContext())
            {
                var tmp =
                    db.BillDetails.SingleOrDefault(x => x.BillID == bID && x.ProductID == pID);
                if (tmp != null)
                {
                    db.BillDetails.DeleteOnSubmit(tmp);
                    try
                    {
                        db.SubmitChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Update(BillDetail bd)
        {
            using (var db = new ShopTPTDataContext())
            {
                var tmp =
                    db.BillDetails.SingleOrDefault(x => x.BillID == bd.BillID && x.ProductID == bd.ProductID);
                if (tmp != null)
                {
                    tmp.BillID = bd.BillID;
                    tmp.ProductID = bd.ProductID;
                    tmp.Quantity = bd.Quantity;
                    tmp.Total = bd.Total;
                    try
                    {
                        db.SubmitChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
