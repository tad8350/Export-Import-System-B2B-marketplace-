using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class EventHandler
    {
        public static bool LoginCheck(int id, String pass, String userType)
        {
            DBDataContext db = new DBDataContext();
            User_Login lg = new User_Login();

            var ob = from p in db.User_Logins
                     where p.User_id == id && p.Pass == pass && p.User_type == userType
                     select p;
            if (ob.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void profileLoader(int id, ref String name, ref String email, ref String country, ref String phn)
        {
            DBDataContext db = new DBDataContext();
            Customer ob = db.Customers.FirstOrDefault(x => x.Customer_id == id);
            name = ob.Customer_name;
            email = ob.Email;
            phn = ob.Phone_number;
            country = ob.Addresses.Country.Country_name;
        }
        public static void userSignUp(String userName, String pass, String email, String userType)
        {
            DBDataContext db = new DBDataContext();
            User_Login lg = new User_Login();
            lg.Pass = pass;
            lg.User_type = userType;
            
            db.User_Logins.InsertOnSubmit(lg);
            db.SubmitChanges();
            
            Customer cm = new Customer();
            cm.Email = email;
            cm.Customer_type = userType;
            db.Customers.InsertOnSubmit(cm);
            db.SubmitChanges();

            Address ad = new Address();
            db.Addresses.InsertOnSubmit(ad);
            db.SubmitChanges();
        }
        public static void showCategory(dynamic ob)
        {
            //BuyerForm ob1 = new BuyerForm();
            int i=0;
            int end=3;
            DBDataContext db = new DBDataContext();
            //Category cs = new Category();
            var cat = from p in db.Categories
                 select p;
            foreach(var x in cat)
            {
                ob.AddCatagory(i, end, x.Category_name);
                i++;
                end += 60;
            }
        }
        public static void showItemList(BuyerForm ob)
        {
            int i=0;
            int end1=3;
            DBDataContext db = new DBDataContext();
            Item it = new Item();

            var cat = from p in db.Items
                      select p;
            foreach(var x in cat)
            {
                ob.AddProductlist(i, end1, x.Item_name, x.Unit_price.ToString(), x.Category.Category_name, x.Item_id.ToString(), x.Image_path);
                end1 += 123;
                i++;
            }

        }
        public static void showItemListCategorywise(CatagoryProductForm ob, String catName)
        {
            int i=0;
            int end=3;
            
            DBDataContext db = new DBDataContext();
            Item it = new Item();
            var list = from p in db.Items
                       where p.Category.Category_name == catName
                       select p;
            foreach(var x in list)
            {
                ob.AddProductlist(i,end,x.Item_name,x.Unit_price.ToString(),x.Category.Category_name,x.Item_id.ToString(),x.Image_path);
            }
        }

        public static void ShowProductDetails(string id, ref String productName, ref String quantity, ref String categoryName, ref String price, ref String details, ref String sellerName, ref String sellerId, ref String phn, ref String Address, ref String email, ref String country)
        {
            DBDataContext db = new DBDataContext();
            Item it = new Item();

            var list = from p in db.Items
                       where p.Item_id == int.Parse(id)
                       select p;
            foreach(var x in list)
            {
                productName = x.Item_name;
                quantity = x.Quantity.ToString();
                categoryName = x.Category.Category_name;
                price = x.Unit_price.ToString();
                details = x.Item_description;
                sellerId = x.Seller_id.ToString();
                sellerName = x.Customer.Customer_name;
                phn = x.Customer.Phone_number;
                email = x.Customer.Email;
                country = x.Customer.Addresses.Country.Country_name;

            }
        }
        public static void createNewOrder(String itemId, String buyerId, String sellerId, String quantity )//not fully developed
        {
            DBDataContext db = new DBDataContext();
            Order ob = new Order();
            ob.Buyer_id = int.Parse(buyerId);
            ob.Seller_id = int.Parse(sellerId);
            ob.Item_id = int.Parse(itemId);
            ob.Quantity = int.Parse("");
            ob.Order_date = System.DateTime.Now;

            db.Orders.InsertOnSubmit(ob);
            db.SubmitChanges();
        }
    }
}
