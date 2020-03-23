using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ado_friends.Models
{
    public class Crud
    {
        private string strConString = @"Data Source=WINBK185139-ETV;Initial Catalog=FriendsAdo;Integrated Security=true;";
        public int InsertStudent(int id, string friendName, string place)
        {

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Insert into Friends2 (FriendId,FriendName,Place) values(@friendid, @friendname , @place)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@friendname", friendName);
                cmd.Parameters.AddWithValue("@friendid", id);
                cmd.Parameters.AddWithValue("@place", place);
                return cmd.ExecuteNonQuery();
            }
        }
        public int UpdateStudent(int id, string friendName, string place)
        {

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Update Friends2 set FriendName=@friendname,Place=@place where FriendId=@friendid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@friendname", friendName);
                cmd.Parameters.AddWithValue("@friendid", id);
                cmd.Parameters.AddWithValue("@place", place);
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Friends2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public int DeleteStudent(int friendID)
        {

            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Delete from Friends2 where FriendId=@friendid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@friendid", friendID);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
