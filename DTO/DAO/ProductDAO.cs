using System;
using System.Collections.Generic;
using System.Linq;
using DTO.Model;

namespace DTO.DAO
{
    public class ProductDao
    {
        private static ProductDao _instance;

        public static ProductDao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductDao();
                }
                return _instance;
            }
        }

        private ProductDao() { }

        public List<Product> View()
        {
            List<Product> lProduct;
            using (var db = new ShopTPTDataContext())
            {
                lProduct = db.Products.Select(x => x).ToList();
                
            }
            return lProduct;
        }

        public Product SelectSingleProduct(string productCode)
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Products.SingleOrDefault(x => x.ProductCode == productCode);
            } 
        }

        public double? GetPrice(int id)
        {
            
            using (var db = new ShopTPTDataContext())
            {
                return db.Products.SingleOrDefault(p => p.ProductID == id).Price;  
            }
        }

        public bool Add(Product product)
        {
            using (var db = new ShopTPTDataContext())
            {
                db.Products.InsertOnSubmit(product);
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {

                    //ig
                }
            }
            return false;
        }

        public List<Product> FindProduct(string key)
        {
            List<Product> lpd;
            using (var db = new ShopTPTDataContext())
            {
                lpd = db.Products.Select(p => p).Where(x=>x.ProductCode.Contains(key) || x.ProductName.Contains(key)).ToList();
            }
            return lpd;
        }


        public bool Update(Product pd)
        {
            using ( var db = new ShopTPTDataContext())
            {
                Product tmp = db.Products.SingleOrDefault(x => x.ProductCode == pd.ProductCode);
                if (tmp != null)
                {
                    tmp.ProductCode = pd.ProductCode;
                    tmp.Image = pd.Image;
                    tmp.Color = pd.Color;
                    tmp.PCCode = pd.PCCode;
                    tmp.Price = pd.Price;
                    tmp.Size = pd.Size;
                    tmp.Quantity = pd.Quantity;
                    tmp.ProductName = pd.ProductName;
                    tmp.Trademark = pd.Trademark;
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
        public void Delete(string pID)
        {
            using (var db = new ShopTPTDataContext())
            {
                var pd = db.Products.SingleOrDefault(x => x.ProductCode == pID);
                if (pd != null) db.Products.DeleteOnSubmit(pd);
                db.SubmitChanges();
            }
        }

        public List<Product> ListProductByCategory(int id)
        {
            using (var db = new ShopTPTDataContext())
            {
                return db.Products.Select(x => x).Where(p => p.PCCode == id).ToList();
            }
        }
    }
}
