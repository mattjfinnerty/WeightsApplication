﻿using System;
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

        public Athlete UpdateAthlete(Athlete athlete)
        {
            SqlConnection conn = new SqlConnection(ConnectionData.ConnectionInfo);
            try
            {
                SqlCommand command = new SqlCommand(ConnectionData.UpdateAthlete, conn)
                                         {CommandType = CommandType.StoredProcedure};
                command.Parameters.AddWithValue("@AthleteId", athlete.AthleteId);
                command.Parameters.AddWithValue("@Forename", athlete.Forename);
                command.Parameters.AddWithValue("@Surname", athlete.Surname);
                if (athlete.Weight != null)
                    command.Parameters.AddWithValue("@Weight", athlete.Weight);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
            return athlete;
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
    }
}
