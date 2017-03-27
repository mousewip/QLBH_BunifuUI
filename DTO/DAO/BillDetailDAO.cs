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

        public bool Delete(int bID, string pID)
        {
            using (var db = new ShopTPTDataContext())
            {
                var tmp =
                    db.BillDetails.SingleOrDefault(x => x.BillCode == bID && x.ProductCode == pID);
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
                    db.BillDetails.SingleOrDefault(x => x.BillCode == bd.BillCode && x.ProductCode == bd.ProductCode);
                if (tmp != null)
                {
                    tmp.BillCode = bd.BillCode;
                    tmp.ProductCode = bd.ProductCode;
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
