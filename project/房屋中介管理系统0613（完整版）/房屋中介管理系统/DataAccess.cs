using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace 房屋中介管理系统
{
    class DataAccess
    {
        private string strDSN;//定义连接字符串strDSN
        OleDbConnection oledbCon;//定义数据库连接对象oledbCon

        public void DataCon()//数据库连接方法
        {//strDSN=版本+数据源+数据库的名称
            strDSN = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\LetttinfAgent.mdb";
            oledbCon = new OleDbConnection(strDSN);//实例化oledbConnection

        }
        public DataSet getDataset(string sql)//获取Dataset
        {
            DataSet ds = new DataSet();//实例化DataSet
            oledbCon.Open();//打开数据表
            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                OleDbDataAdapter oledbDa = new OleDbDataAdapter(oledbCom);
                oledbDa.Fill(ds);
                return ds;
            }
            catch (Exception ex)//捕获异常
            {
                throw new Exception(ex.ToString());//抛出提示
            }
            finally
            {
                oledbCon.Close();
            }
        }
        public bool sqlExec(string sql)//执行SQL语句
        {
            try
            {
                oledbCon.Open();
            }
            catch
            {
                MessageBox.Show("数据库连接失败");
            }
            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);//实例化
                oledbCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                return false;
            }
            finally
            {
                oledbCon.Close();
            }
        }
    
    }
}
