using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićTournamentTracker
{
    public static class GlobalConfig
    {
        public static <IDataConnection Connections { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {
            if (db== DatabaseType.Sql)
            {
                //Stvoriti SQL veza
                SqlConnector sql = new SqlConnector();
                Connections =sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //Stvoriti text veza
                TextConnector text = new TextConnector();
                Connections=text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
