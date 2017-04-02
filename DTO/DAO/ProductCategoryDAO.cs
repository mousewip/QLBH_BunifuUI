using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Model;

namespace DTO.DAO
{
    public class ProductCategoryDAO
    {
        private static ProductCategoryDAO _instance;

        public static ProductCategoryDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductCategoryDAO();
                }
                return _instance;
            }
        }

        private ProductCategoryDAO() { }


        public List<ProductCategory> View()
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.ProductCategories.Select(x => x).ToList();
            }
        }


        public ProductCategory SelectSingleProductCategory(int? productCategoryId)
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.ProductCategories.SingleOrDefault(x => x.PCCode == productCategoryId);
            }
        }

        public bool Add(ProductCategory pc)
        {
            using (var db = new ShopTPTDataContext())
            {
                db.ProductCategories.InsertOnSubmit(pc);
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

        public bool Delete(int pcID)
        {
            using (var db = new ShopTPTDataContext())
            {
                var pc = db.ProductCategories.SingleOrDefault(x => x.PCCode == pcID);
                if (pc != null)
                {
                    db.ProductCategories.DeleteOnSubmit(pc);
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

        public bool Update(ProductCategory pc)
        {
            using (var db = new ShopTPTDataContext())
            {
                var tmp = db.ProductCategories.SingleOrDefault(x => x.PCCode == pc.PCCode);
                if (tmp != null)
                {
                    tmp.PCCode = pc.PCCode;
                    tmp.PCName = pc.PCName;
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
