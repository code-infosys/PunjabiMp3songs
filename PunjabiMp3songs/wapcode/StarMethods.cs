using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PunjabiMp3songs
{
    public class StarMethods
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["SqlConnectionString"].ToString());

        public DataTable GetTracksDetail(Int64 songid)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "selectDetail");
                cmd.Parameters.Add("@songid", songid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                 
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }

            
        }

        public DataTable GetTracksDownload(Int64 songid)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "download");
                cmd.Parameters.Add("@songid", songid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
             
        }

        public DataTable GetTracksByMonth(int month)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "bymonth");
                cmd.Parameters.Add("@monthid", month);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public DataTable GetAlbums()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(); 
                string ssql = "select ID,AlbumName,SingerName from MasterAlbum where IsActive=@IsActive order by DateAdded desc";
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = ssql;
                da.SelectCommand.Parameters.Add("@IsActive", 1);
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            { 
                throw;
            }
        }

        public DataTable GetAlbumsDetail(decimal albumid)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                string ssql = "select ID,SongTitle,SingerName,DownloadCount from TracksWraper WHERE AlbumID=@AlbumID AND IsApproved=1 ORDER BY DateAdded DESC";
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = con;
                da.SelectCommand.CommandText = ssql;
                da.SelectCommand.Parameters.Add("@AlbumID", albumid);
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetTracksAtoZ(string albpa)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action", "namewise");
                cmd.Parameters.Add("@alphabit", albpa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public DataTable GetTracksRecAndTop20weekAndTop20month(string action)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectMU";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@Action",action); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataTable SearchBoxFull(string Query,string Action)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " select ID, SongTitle, SingerName, DateAdded from TracksWraper where IsApproved=1 and  (SongTitle like '%" + Query + "%' or SingerName like '%"+Query+"%') order by DateAdded desc";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con; 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }


        MSContextDataContext conTxt = new MSContextDataContext();

        public string GetTrackName(decimal id)
        {
           var qu=  conTxt.TracksWrapers.FirstOrDefault(i => i.ID == id);
           return qu.SongTitle + " (" + qu.SingerName + ")";
        }

        public TracksWraper[] trackLatest()
        {
            return conTxt.TracksWrapers.Where(i => i.IsApproved == null).OrderByDescending(i => i.DateAdded).ToArray();
        }

    }
}