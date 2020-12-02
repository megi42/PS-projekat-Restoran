﻿using Domain;
using System;
using Storage;
using Storage.Implementation.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerBL
{
    public class Controller
    {
        //private IStorageUser storageUser;
        private IStorageProduct storageProduct;
        //public User LoggedInUser { get; set; }

        private static Controller controller;
        public static Controller Instance
        {
            get
            {
                if (controller == null)
                {
                    controller = new Controller();
                }
                return controller;
            }
        }

        private Controller()
        {
            storageProduct = new StorageProductSqlServer();
        }
        //public User Login(string username, string password)
        //{
        //    foreach (User u in storageUser.GetAll())
        //    {
        //        if (u.Username == username && u.Password == password)
        //        {
        //            LoggedInUser = u;
        //            return u;
        //        }
        //    }
        //    throw new Exception("Login failed");
        //}
        public List<Product> GetAllProducts()
        {
            return storageProduct.GetAll();
        }

        public void SaveProduct(Product p)
        {
            storageProduct.Save(p);
        }
    }
}