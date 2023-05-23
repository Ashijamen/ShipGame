using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipGame
{
    public class InfoResponse
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
    }
   public class ServiceResponse
    {
        public string ResponseJson { get; set; }

        public int StausCode { get; set; }

    }

    public class ServiceData
    {
        public dynamic Data { get; set; }

        public int StausCode { get; set; }

    }

    public class EmptyResponse
    {
        
    }

    public class SuccessCreateGameResponse
    {
            public string NewGameCode { get; set; }
    }

    public class SuccessGetPlayerByName
    {
            public int playerIndex { get; set; }
    }
    public class SuccessGetPlayerShips
    {
            public List<Point> ships { get; set; }
    }

    public class SuccessGetPlayerWithTour
    {
            public int playerId { get; set; }
    }
}
