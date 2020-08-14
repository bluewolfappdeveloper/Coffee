using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffee.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO() ; return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }
        private CustomerDAO() { }

        public bool add(string a, string b, string c, string h)
        {
            string query = "EXEC USP_khachhang @num , @id , @name , @donvi , @du , @thieu , @tienno , @ghichu ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 1, a, b, c, 0, 0, 0, h });

            return k>0;
        }

        public bool delete(string a, string b, string c, string d, string e,string g, string h)
        {
            string query = "EXEC USP_khachhang @num , @id , @name , @donvi , @du , @thieu , @tienno , @ghichu ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 2, a, b, c, d, e, g, h });
            return k > 0;
        }
        public bool repair(string a, string b, string c, string d, string e,string g, string h)
        {
            string query = "EXEC USP_khachhang @num , @id , @name , @donvi , @du , @thieu , @tienno , @ghichu ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 3, a, b, c, d, e, g, h });

            return k > 0;
        }



        
    }
}
