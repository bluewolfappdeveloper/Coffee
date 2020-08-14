using coffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace coffee.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public bool login(string username, string password)
        {
            string query = "EXEC dbo.USP_Login @username , @password";

            DataTable table = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { username, password });

            return table.Rows.Count > 0;
        }
    }
}
