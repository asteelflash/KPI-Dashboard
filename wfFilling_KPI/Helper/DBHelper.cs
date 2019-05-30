using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace wfFilling_KPI.Helper
{
    class DBHelper
    {
        private static string connStr = "";

        public static string ConnString
        {
            get { return connStr; }
            set { connStr = value; }
        }

        private string GetConnectString()
        {
            try
            {
                if (String.IsNullOrEmpty(connStr))
                {
                    connStr = System.Configuration.ConfigurationManager.AppSettings["connectionstringReport"].ToString();
                    connStr = Encrypt.DesDecrypt(connStr);                   
                }
                return connStr == null ? "" : connStr;
            }
            catch
            {
                return "";
            }
        }

        private SqlConnection CreateConnection()
        {
            string connString = GetConnectString();
            try
            {
                if (String.IsNullOrEmpty(connString))
                {
                    return null;
                }
                else
                {
                    SqlConnection cn = new SqlConnection(connString);
                    cn.Open();
                    return cn;
                }
            }
            catch
            {
                return null;
            }
        }

        private void CloseConnection(SqlConnection cn)
        {
            try
            {
                if (cn == null)
                {
                    return;
                }
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            finally
            {
                cn.Dispose();
                cn = null;
            }
        }

        public DataTable ExecuteReturnDataTable(string sql)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataTable dt = new DataTable())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public DataTable ExecuteReturnDataTable(string sql, SqlParameter[] para)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataTable dt = new DataTable())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(para);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public DataTable ExecuteReturnDataTable(string sql, string[,] stringArray)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataTable dt = new DataTable())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] para = CreateSqlParas(stringArray);
                    cmd.Parameters.AddRange(para);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public DataSet ExecuteReturnDataSet(string sql)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataSet ds = new DataSet())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public DataSet ExecuteReturnDataSet(string sql, SqlParameter[] para)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataSet ds = new DataSet())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddRange(para);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public DataSet ExecuteReturnDataSet(string sql, string[,] stringArray)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                using (DataSet ds = new DataSet())
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    SqlParameter[] para = CreateSqlParas(stringArray);
                    cmd.Parameters.AddRange(para);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(ds);
                    return ds;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public void ExecuteReturnless(string sqlStatement)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                SqlCommand cmd = new SqlCommand(sqlStatement, cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public void ExecuteReturnless(string sql, SqlParameter[] para)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddRange(para);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public void ExecuteReturnless(string sql, string[,] stringArray)
        {
            SqlConnection cn = null;
            try
            {
                cn = CreateConnection();
                if (cn == null)
                {
                    throw new Exception("Connection is null");
                }
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
                SqlParameter[] para = CreateSqlParas(stringArray);
                cmd.Parameters.AddRange(para);
                //if (para != null)
                //{
                //    if (para.Length != 0)
                //    {
                //        for (int i = 0; i < para.Length; i++)
                //        {
                //            cmd.Parameters.Add(para[i]);
                //        }
                //    }
                //}

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                CloseConnection(cn);
            }
        }

        public SqlParameter[] CreateSqlParas(string[,] para)
        {
            SqlParameter[] sqlPara = new SqlParameter[para.Length / 2];
            for (int i = 0; i < para.Length / 2; i++)
            {
                sqlPara[i] = new SqlParameter();
                sqlPara[i].ParameterName = para[i, 0].ToString();
                sqlPara[i].Value = para[i, 1].ToString();
            }
            return sqlPara;
        }
    }
}
