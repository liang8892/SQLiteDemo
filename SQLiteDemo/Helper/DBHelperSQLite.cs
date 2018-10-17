using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDemo
{
    public static class DBHelperSQLite
    {
        //private static SQLiteConnection SQLite_CONNECTION;

        /// <summary>
        /// 创建一个空数据库文件
        /// </summary>
        /// <param name="dbName">文件名称</param>
        /// <returns>创建结果</returns>
        public static bool CreateDataBase(string dbName, ref string message)
        {
            try
            {
                SQLiteConnection.CreateFile(dbName);
                message = $"成功创建数据库文件{dbName}。";
                return true;
                //return $"成功创建数据库文件{dbName}。";
            }
            catch (Exception e)
            {
                message = e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 创建一个到指定数据库的连接
        /// </summary>
        /// <param name="dbName">指定数据库文件</param>
        /// <returns>连接是否成功</returns>
        public static SQLiteConnection OpenDataBase(string dbName)
        {
            try
            {
                SQLiteConnection SQLite_CONNECTION = new SQLiteConnection($"Data Source={dbName};Version=3;");
                SQLite_CONNECTION.Open();
                return SQLite_CONNECTION;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        /// <summary>
        /// 在指定数据库中创建数据表
        /// </summary>
        /// <param name="dbName">指定数据库</param>
        /// <param name="tbName">数据表名</param>
        /// <param name="columns">表中字段</param>
        /// <returns>创建结果</returns>
        public static bool CreateDataTable(string dbName, string tbName, string columns, ref string message)
        {
            try
            {
                string sql = $"create table {tbName} ({columns})";
                SQLiteConnection conn = OpenDataBase(dbName);
                SQLiteCommand comm = new SQLiteCommand(sql, conn);
                comm.ExecuteNonQuery();
                message = $"成功创建数据表{tbName}。";
                return true;
            }
            catch (Exception e)
            {
                message = e.ToString();
                return false;
            }
        }


        //public static bool ExecuteSQL()
        //{
            
        //}

        //public static DataSet Query()
        //{
            
        //}
    }
}
