using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightsV1.ObjectCreation
{
    class Athlete
    {
        public int AthleteId { get; private set; }
        public string Forename { get; private set; }
        public string Surname { get; private set; }
        public double? Weight { get; private set; }

        private Athlete()
        {
            AthleteId = 0;
            Forename = null;
            Surname = null;
            Weight = null;
        }

        public Athlete(int athleteId)
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlCommand cmdAthlete = new SqlCommand("GetAthleteById", conn)
                                            {CommandType = CommandType.StoredProcedure};
                cmdAthlete.Parameters.AddWithValue("@AthleteId", athleteId);
                conn.Open();
                SqlDataReader reader = cmdAthlete.ExecuteReader();
                while(reader.Read())
                {
                    AthleteId = (int)reader["AthleteId"];
                    Forename = (string)reader["Forename"];
                    Surname = (string)reader["Surname"];
                    Weight = reader["WeightKG"] == DBNull.Value ? null : (double?)reader["WeightKG"];
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

        public Athlete(string forename, string surname, double? weight)
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlCommand command = new SqlCommand(ConnectionData.AddAthlete, conn) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@Forename", forename);
                command.Parameters.AddWithValue("@Surname", surname);
                if (weight != null)
                    command.Parameters.AddWithValue("@WeightKG", weight);
                SqlParameter athId = new SqlParameter("@AthleteID", 0);
                athId.Direction = ParameterDirection.Output;
                command.Parameters.Add(athId);
                conn.Open();
                command.ExecuteNonQuery();
                AthleteId = Convert.ToInt32(athId.Value);
                Forename = forename;
                Surname = surname;
                Weight = weight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Athlete> GetAllAthletes()
        {
            List<Athlete> allAthletes = new List<Athlete>();
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter
                                             {
                                                 SelectCommand =
                                                     new SqlCommand(ConnectionData.GetAllAthletes, conn)
                                                         {CommandType = CommandType.StoredProcedure}
                                             };

                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Athlete newAthlete = new Athlete();
                    newAthlete.AthleteId = (int) dr[0];
                    newAthlete.Forename = (string) dr[1];
                    newAthlete.Surname = (string) dr[2];
                    newAthlete.Weight = dr[3] == DBNull.Value ? null : (double?) dr[3];
                    allAthletes.Add(newAthlete);
                }
                return allAthletes;
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

        public bool UpdateAthlete()
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            if (AthleteId == 0 || string.IsNullOrEmpty(Forename) || string.IsNullOrEmpty(Surname)) return false;
            try
            {
                SqlCommand command = new SqlCommand(ConnectionData.UpdateAthlete, conn)
                                         {CommandType = CommandType.StoredProcedure};
                command.Parameters.AddWithValue("@AthleteId", AthleteId);
                command.Parameters.AddWithValue("@Forename", Forename);
                command.Parameters.AddWithValue("@Surname", Surname);
                if (Weight != null)
                    command.Parameters.AddWithValue("@Weight", Weight);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool DeleteAthlete(Athlete athlete)
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlCommand command = new SqlCommand(ConnectionData.DeleteAthlete, conn)
                    {CommandType = CommandType.StoredProcedure};
                command.Parameters.AddWithValue("@AthleteId", athlete.AthleteId);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public override string ToString()
        {
            string athleteString = "Athlete Id: " + AthleteId + ", " + Forename + " " + Surname;
            return athleteString;
        }
    }
}
