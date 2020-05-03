﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@PlaceNumber int;
//@PlaceName nvarchar(50);
//@PrizeAmount money;
//@PrizePercentage float;
//@id int =0 output;

namespace markoGalavićTournamentTracker
{
    public class SqlConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
           using (IDbConnection connection=new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p new DynamicParameters();
                p.Add("@PlaceNumber",model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id",0,dbType:DbType.Int.32,direction:ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
    }
}
