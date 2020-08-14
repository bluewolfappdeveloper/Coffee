using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffee.DAO
{
    public class SellDAO
    {
        private static SellDAO instance;

        public static SellDAO Instance
        {
            get { if (instance == null) instance = new SellDAO(); return SellDAO.instance; }
            set { SellDAO.instance = value; }
        }
        private SellDAO() { }

        public bool add(string a,string b,Int64 c, Int64 d,Int64 e)
        {
            string query = "EXEC USP_Bill @num , @id , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {1,a,b,c,d,e});

            return k>0;
        }
        public bool delete(string a, string b, Int64 c, Int64 d, Int64 e)
        {
            string query = "EXEC USP_Bill @num , @id , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {2,a,b,c,d,e});
            return k > 0;
        }
        public bool repair(string a, string b, Int64 c, Int64 d, Int64 e)
        {
            string query = "EXEC USP_Bill @num , @id , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {3, a, b, c, d, e });

            return k > 0;
        }

    } 
}
