using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightsV1.ObjectCreation
{
    class ExcerciseType
    {
        public int ExcerciseTypeId { get; private set; }
        public string ExcerciseTypeDesc { get; private set; }

        private ExcerciseType()
        {
            ExcerciseTypeId = 0;
            ExcerciseTypeDesc = null;
        }

        public ExcerciseType(int excerciseTypeId)
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                ExcerciseTypeId = excerciseTypeId;
                SqlCommand cmdAthlete = new SqlCommand(ConnectionData.GetExcerciseTypeById, conn) { CommandType = CommandType.StoredProcedure };
                cmdAthlete.Parameters.AddWithValue("@ExcerciseTypeId", excerciseTypeId);
                conn.Open();
                SqlDataReader reader = cmdAthlete.ExecuteReader();
                while (reader.Read())
                {
                    ExcerciseTypeDesc = (string)reader["ExcerciseTypeDesc"];
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<ExcerciseType> GetAllExcerciseTypes()
        {
            List<ExcerciseType> allExcerciseTypes = new List<ExcerciseType>();
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand =
                        new SqlCommand(ConnectionData.GetAllExcerciseTypes, conn) { CommandType = CommandType.StoredProcedure }
                };

                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ExcerciseType newExcerciseType = new ExcerciseType();
                    newExcerciseType.ExcerciseTypeId = (int)dr[0];
                    newExcerciseType.ExcerciseTypeDesc = (string)dr[1];
                    allExcerciseTypes.Add(newExcerciseType);
                }
                return allExcerciseTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
