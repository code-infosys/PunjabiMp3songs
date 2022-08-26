using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace PunjabiMp3songs 
{
    public class Datastar
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        int CmdTimeout = 2000;
        string connectionstring = ConfigurationManager.AppSettings["SqlConnectionString"].ToString();
        public void openconnection()
        { 
            if (cn == null)
                cn = new SqlConnection(connectionstring);
            try
            {
                //Open connection prior to check connection state  
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                //Initialized Command object
                cmd = new SqlCommand();
                //Set command obj with connection
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
 

        }
        public void closeconnection()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void disposeconnection()
        {

            try
            {
                if (cn != null)
                    cn.Dispose();
                cn = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


       
         

        public DataSet getDataSet(string Sqlstr)
        {

            DataSet ds = new DataSet();
            try
            {

                openconnection();
                SqlDataAdapter da = new SqlDataAdapter(Sqlstr, cn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeconnection();
                disposeconnection();
            }
            return ds;




        }
        public int ExecuteSql(string Sqlstr)
        {

            int intResult = 0;

            try
            {
                openconnection();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Sqlstr;
                cmd.CommandTimeout = CmdTimeout;
                intResult = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeconnection();
                disposeconnection();
            }
            return intResult;
        }
        public DataTable getDataTable(string Sqlstr)
        {

            DataTable dt = new DataTable();
            try
            {
                openconnection();

                SqlDataAdapter da = new SqlDataAdapter(Sqlstr, cn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeconnection();
                disposeconnection();

            }
            return dt;

        }
        public SqlDataReader GetDataReader(string Sqlstr)
        {
            SqlDataReader dr;

            try
            {
                openconnection();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Sqlstr;
                cmd.CommandTimeout = CmdTimeout;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dr;

        }

        public bool GetScaler(String strsql)
        {
            int intResult = 0;
            //set command obj properties
            try
            {
                openconnection();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strsql;
                cmd.CommandTimeout = CmdTimeout;

                intResult = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeconnection();
                disposeconnection();
            }
            if (intResult > 0)
                return true;
            else
                return false;
        }


        public DataTable GetDataParam(string sql, SqlParameter[] Arrparam)
        {
            DataTable dt = new DataTable();

            try
            {
                openconnection();
                SqlParameter param = new SqlParameter();

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;

                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter loopParam in Arrparam)
                {
                    param = loopParam;
                    cmd.Parameters.Add(param);
                }
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                closeconnection();
                disposeconnection();
            }
            return dt;
        }


        public int InsUpDelparam(string sql, SqlParameter[] Arrparam)
        {
            int r = 0;

            try
            {
                openconnection();

                SqlParameter param = new SqlParameter();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter Loopparam in Arrparam)
                {
                    param = Loopparam;
                    cmd.Parameters.Add(param);
                }
                r = cmd.ExecuteNonQuery();
            }
            catch (Exception er)
            {
                throw er;
            }
            finally
            {
                closeconnection();
                disposeconnection();
            }

            return r;
        }


        public int GetMaxId(string table_name, string column_name)
        {

            openconnection();
            int sonu = 0;
            try
            {
                string query = "select isnull(max(" + column_name + ")+1,1) from " + table_name + " ";
                SqlCommand cmd = new SqlCommand(query, cn);
                sonu = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeconnection();
                disposeconnection();

            }
            return sonu;
        }

        public void dispose_datatable(DataTable dt)
        {
            dt.Clear();
            dt.Dispose();
        }
        public void dispose_dataset(DataSet ds)
        {
            ds.Clear();
            ds.Dispose();
        }

        public string getImage(string path)
        {
            string strImg = string.Empty;
            strImg = "starimg/" + path;
            return strImg.ToString();
        }
        public int UpdateClick(string table_name, string column_name, string id)
        {
            openconnection();
            int ab = 0;
            try
            {
                string query = "update " + table_name + " set most_view=isnull(most_view+1,1)  where " + column_name + "='" + id + "'  ";
                ab = ExecuteSql(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ab;
        }




        public string TimeAgo(DateTime date)
        {

            TimeSpan timeSince = DateTime.Now.Subtract(date);

            if (timeSince.TotalMilliseconds < 1)
                return "not yet";
            if (timeSince.TotalMinutes < 1)
                return "just now";
            if (timeSince.TotalMinutes < 2)
                return "1 minute ago";
            if (timeSince.TotalMinutes < 60)
                return string.Format("{0} minutes ago", timeSince.Minutes);
            if (timeSince.TotalMinutes < 120)
                return "1 hour ago";
            if (timeSince.TotalHours < 24)
                return string.Format("{0} hours ago", timeSince.Hours);
            if (timeSince.TotalDays == 1)
                return "yesterday";
            if (timeSince.TotalDays < 7)
                return string.Format("{0} days ago", timeSince.Days);
            if (timeSince.TotalDays < 14)
                return "last week";
            if (timeSince.TotalDays < 21)
                return "2 weeks ago";
            if (timeSince.TotalDays < 28)
                return "3 weeks ago";
            if (timeSince.TotalDays < 60)
                return "last month";
            if (timeSince.TotalDays < 365)
                return string.Format("{0} months ago", Math.Round(timeSince.TotalDays / 30));
            if (timeSince.TotalDays < 730)
                return "last year";

            //last but not least...
            return string.Format("{0} years ago", Math.Round(timeSince.TotalDays / 365));

        }

        public Bitmap ResizeImage(Stream streamImage, int maxWidth, int maxHeight)
        {
            Bitmap originalImage = new Bitmap(streamImage);
            int newWidth = originalImage.Width;
            int newHeight = originalImage.Height;
            double aspectRatio = (double)originalImage.Width / (double)originalImage.Height;

            if (aspectRatio <= 1 && originalImage.Width > maxWidth)
            {
                newWidth = maxWidth;
                newHeight = (int)Math.Round(newWidth / aspectRatio);
            }
            else if (aspectRatio > 1 && originalImage.Height > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)Math.Round(newHeight * aspectRatio);
            }

            Bitmap newImage = new Bitmap(originalImage, newWidth, newHeight);

            Graphics g = Graphics.FromImage(newImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.DrawImage(originalImage, 0, 0, newImage.Width, newImage.Height);

            originalImage.Dispose();

            return newImage;
        }


        public DataTable getLogin(string email, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                openconnection();
                string ssql = "select ID,UserName,EmailID from UserUploader where EmailID=@EmailID and UserPW=@UserPW and IsDeleted=0";
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = ssql;
                da.SelectCommand.Parameters.Add("@EmailID", email);
                da.SelectCommand.Parameters.Add("@UserPW", password);
                da.Fill(dt); 
                return dt;
                 
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable getLoginBackend(string email, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                openconnection();
                string ssql = "select ID,UserName,EmailID from AdminUser where EmailID=@EmailID and UserPW=@UserPW and IsActive=1";
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = ssql;
                da.SelectCommand.Parameters.Add("@EmailID", email);
                da.SelectCommand.Parameters.Add("@UserPW", password);
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        


    }
}