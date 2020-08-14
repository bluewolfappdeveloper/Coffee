using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using coffee.DAO;
using System.Data;

namespace coffee.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO() ; return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }
        private EmployeeDAO() { }

        public bool add(string a,string b,string c, string d, string e,string f,string g, string h)
        {
            string query = "EXEC USP_Employee @num , @id , @name , @username , @password , @ngaysinh , @diacchi , @dienthoai , @status ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] {1,a,b,c,d,e,f,g,h});
          
            return k>0;
        }

        public bool delete(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            string query = "EXEC USP_Employee @num , @id , @name , @username , @password , @ngaysinh , @diacchi , @dienthoai , @status ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 2, a, b, c, d, e, f, g, h});

            return k > 0;
        }
        public bool repair(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            string query = "EXEC USP_Employee @num , @id , @name , @username , @password , @ngaysinh , @diacchi , @dienthoai , @status ";
            int k = (int)DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { 3, a, b, c, d, e, f, g, h });

            return k > 0;
        }
    }
}
