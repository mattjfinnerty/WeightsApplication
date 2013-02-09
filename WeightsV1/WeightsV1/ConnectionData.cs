using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeightsV1
{
    static class ConnectionData
    {
        public const string ConnectionInfo =
            "data source = localhost\\mattsql;Database=Weights;Integrated Security = SSPI;Connection Timeout = 5";

        public const string GetAllAthletes = "GetAllAthletes";

        public const string UpdateAthlete = "UpdateAthlete";

        public const string DeleteAthlete = "DeleteAthlete";
    }
}
