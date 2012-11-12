using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Data.SqlClient;
using System.Drawing;

namespace WeightsV1
{
    class Graph
    {

        private int mLastColor;
        private Color[] mColors = { Color.Red, Color.Blue, Color.Purple, Color.Yellow, Color.Green, Color.HotPink };

        public static void CreateHomePageGraph(ZedGraphControl zgc, string excercise)
        {
            //Clear the previous entries present in the graph before redrawing
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            zgc.Invalidate();
            GraphPane myPane =  zgc.GraphPane;

            //Now add data relevant to this iteration
            

            myPane.Title.Text = excercise;
            myPane.YAxis.Title.Text = "Weight (KG)";
            myPane.XAxis.Title.Text = "Date";
           
            //Create an SqlConnection and populate the grid!

            SqlConnection conn = new SqlConnection("data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5");
            conn.Open();
            SqlCommand cmdExcerciseID = new SqlCommand("Select [ExcerciseID] from Excercise where ExcerciseName = '" + excercise + "'", conn);
            int excerciseID = (int)cmdExcerciseID.ExecuteScalar(); //ExcerciseID retrieved for use in dbo.Record

            //Create an IList instance of all athletes who have done this Excercise

            List<int> athleteIds = new List<int>();

            SqlCommand cmdAthleteIds = new SqlCommand("Select distinct [AthleteID] from Record where ExcerciseID = " + excerciseID, conn);
            SqlDataReader readAthIds = cmdAthleteIds.ExecuteReader();
            while (readAthIds.Read())
            {
                athleteIds.Add(Convert.ToInt32(readAthIds[0]));
            }
            readAthIds.Close();
            //Now add a line for each athlete!

            Graph graph1 = new Graph();

            foreach (int athlete in athleteIds)
            {
                PointPairList coordinates = new PointPairList();
                SqlCommand cmdRecord = new SqlCommand("Select Top 10 [RecordDate], [Weight] from Record where AthleteID = " + athlete + " and ExcerciseID = " + excerciseID + " Order By RecordDate desc", conn);
                SqlDataReader readRecord = cmdRecord.ExecuteReader();
                while (readRecord.Read())
                {
                    XDate recordDate = new XDate();
                    double weight;
                    recordDate = readRecord.GetDateTime(0);
                    weight = readRecord.GetDouble(1);
                    double forcedRecDate = recordDate;
                    coordinates.Add(forcedRecDate, weight);
                }
                readRecord.Close();
                //Get the Athlete name for the line name

                SqlCommand cmdAthleteName = new SqlCommand("Select [Forename] + ' ' + [Surname] from Athlete where AthleteID = " + athlete, conn);
                string athleteName = (string)cmdAthleteName.ExecuteScalar();

                //Now add the curve for this athlete

                Color color = graph1.GetNextColor();

                myPane.AddCurve(athleteName, coordinates, color, SymbolType.Default);
            }

            myPane.XAxis.Type = AxisType.Date;
            zgc.AxisChange();
            conn.Close();
        }

        private Color GetNextColor()
        {
               if (mLastColor >= mColors.Length) mLastColor = 0;
                 return mColors[mLastColor++];
        }
    }
}
