using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffee.DAO
{
    public class SellBillDAO
    {
        private static SellBillDAO instance;

        public static SellBillDAO Instance
        {
            get { if (instance == null) instance = new SellBillDAO(); return SellBillDAO.instance; }
            set { SellBillDAO.instance = value; }
        }
        private SellBillDAO() { }

        public bool add(string a,string b, string c,Int64 d, Int64 e,Int64 f)
        {
            string query = "EXEC USP_SellBill @num , @id , @idtable , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {1,a,c,b,d,e,f});

            return k>0;
        }
        public bool delete(string a, string b, string c, Int64 d, Int64 e, Int64 f)
        {
            string query = "EXEC USP_SellBill @num , @id , @idtable , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {2,a,c,b,d,e,f});
            return k > 0;
        }
        public bool repair(string a, string b, string c, Int64 d, Int64 e, Int64 f)
        {
            string query = "EXEC USP_SellBill @num , @id , @idtable , @namedrink , @price , @quantify , @total ";
            Int64 k = (Int64)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {3, a, c,b, d, e,f });

            return k > 0;
        }

    } 
}
