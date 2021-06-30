using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebWorkingDB.DAO
{
    public class Database
    {
        internal static SqlConnection getConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["dbString"].ToString();
            return new SqlConnection(strCon);
        }
        internal static DataTable getDataSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // database Cache
            ds.Clear();
            da.Fill(ds);
            return ds.Tables[0];
        }
        internal static void Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, getConnection());
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        internal static void DeleteProduct(string id)
        {
            Database.Execute("delete from Products where ProductID ='" + id + "'");
        }
        internal static void DeleteOrderDetail(string id)
        {
            Database.Execute("delete from [Order Details] where ProductID ='" + id + "'");
        }
        internal static void Edit(string name, string price,string ddlDanhmuc,string discontinued, string id)
        {
            Database.Execute("update Products set ProductName = '"+name+ "', UnitPrice = '" + price + "', CategoryID = '" + ddlDanhmuc + "',discontinued = '" + discontinued + "'  where ProductID ='" + id + "'");
        }
        internal static void Edit(string name,string id)
        {
            Database.Execute("update Products set ProductName = '" + name + "'  where ProductID ='" + id + "'");
        }
        internal static DataTable getAllcategories()
        {
            return getDataSql("select * from categories");
        }

        internal static DataTable getProductByCateID(string id)
        {
            return getDataSql("select ProductID ,ProductName, UnitPrice from Products where CategoryID = '"+id+"' ");

        }
        internal static DataTable getProductById(string id)
        {
            return getDataSql("select * from Products where ProductID = '"+id+"' ");

        }

    }
}