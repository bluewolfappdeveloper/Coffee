
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffee.DAO
{
    class ItemDAO
    {
        private static ItemDAO instance;

        public static ItemDAO Instance
        {
            get { if (instance == null) instance = new ItemDAO(); return ItemDAO.instance; }
            private set { ItemDAO.instance = value; }
        }

        private ItemDAO() { }
        public bool add(string a, string b, long c)
        {
            string query = "EXEC USP_Item @num , @id , @name , @price";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 1, a, b, c});

            return k > 0;
        }

        public bool delete(string a, string b, long c)
        {
            string query = "EXEC USP_Item @num , @id , @name  , @price";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 2, a, b, c});
            return k > 0;
        }
        public bool repair(string a, string b, long c)
        {
            string query = "EXEC USP_Item @num , @id , @name  , @price";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 3, a, b, c});

            return k > 0;
        }

      

        
    }
}
