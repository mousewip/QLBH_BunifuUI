using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Model;

namespace DTO.DAO
{
    public class BillDAO
    {
        private static BillDAO _instance;

        public static BillDAO Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new BillDAO();
                return _instance;
            }
        }

        private BillDAO() { }


        public List<Bill> View()
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Bills.Select(x => x).ToList();
            }
        }

        public bool Add(Bill bill)
        {
            using (var db = new ShopTPTDataContext())
            {
                db.Bills.InsertOnSubmit(bill);
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

        public bool Update(Bill bill)
        {
            using (var db = new ShopTPTDataContext())
            {
                var tmp = db.Bills.SingleOrDefault(x => x.BillID == bill.BillID);
                if (tmp != null)
                {
                    tmp.BillID = bill.BillID;
                    tmp.CreateDate = bill.CreateDate;
                    tmp.TotalAmount = bill.TotalAmount;
                    tmp.UserCode = bill.UserCode;
                    tmp.CustomerName = bill.CustomerName;
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


        public bool Delete(int bID)
        {
            using (var db = new ShopTPTDataContext())
            {
                var bill = db.Bills.SingleOrDefault(x => x.BillID == bID);
                if (bill != null)
                {
                    db.Bills.DeleteOnSubmit(bill);
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
