using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ShipGame
{
    class BackendApi
    {
        public static ServiceData CreateGame(CreateGame bodyData) 
        {
            ServiceData serviceData = new ServiceData(); 
            string jsonBody = JsonConvert.SerializeObject(bodyData);

            ServiceResponse response = RequestSender.Post("/game", jsonBody).Result;

            if(response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<SuccessCreateGameResponse>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }

        public static ServiceData AddPlayerTwo(AddPlayer bodyData)
        {
            ServiceData serviceData = new ServiceData();
            string jsonBody = JsonConvert.SerializeObject(bodyData);

            ServiceResponse response = RequestSender.Put("/player/two", jsonBody).Result;

            if (response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<EmptyResponse>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }

        public static ServiceData GetPlayerTour(string tableName, string playerName)
        {
            ServiceData serviceData = new ServiceData();

            ServiceResponse response = RequestSender.Get(
                "/player/index", 
                $@"?tableName={tableName}&playerName={playerName}"
            ).Result;

            if (response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<SuccessGetPlayerByName>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }
    }
}
