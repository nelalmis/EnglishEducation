using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business
{
    public class Lesson
    {
        public Types.Lesson SelectByKey()
        {
            //sp 
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand("sel_LessonByKey", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@LessondId", SqlDbType.Int);
            var reader = cmd.ExecuteReader();
            Types.Lesson contract = new Types.Lesson();
            List<Types.Lesson> list = new List<Types.Lesson>();
            while (reader.Read())
            {
                contract.LessonId = Convert.ToInt32( reader["LessonId"]);
                contract.LessonName = Convert.ToString(reader["LessonName"]);
                contract.LessonDate = Convert.ToDateTime(reader["LessonDate"]);
                //list.Add(contract);
                break;
                +++++++++++++
            }
            
            return contract;
        }
        public int Insert(Types.Lesson contract)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand("ins_Lesson", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LessondName",contract.LessonName);
            cmd.Parameters.AddWithValue("@LessonDate", contract.LessonDate);
            var response = cmd.ExecuteNonQuery();
            return response;

        }
        public void SelectByColumns()
        {

        }
    }
}
