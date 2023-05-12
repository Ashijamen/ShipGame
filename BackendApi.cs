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

        public static ServiceData GetPlayerId(string tableName, string playerName)
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

        public static ServiceData GetPlayerAvailableShips(string tableName, string playerName)
        {
            ServiceData serviceData = new ServiceData();

            ServiceResponse response = RequestSender.Get(
                "/ships/all/available",
                $@"?tableName={tableName}&playerName={playerName}"
            ).Result;

            if (response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<SuccessGetPlayerShips>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }

        public static ServiceData GetPlayerNotAvailableShips(string tableName, string playerName)
        {
            ServiceData serviceData = new ServiceData();

            ServiceResponse response = RequestSender.Get(
                "/ships/all/not-available",
                $@"?tableName={tableName}&playerName={playerName}"
            ).Result;

            if (response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<SuccessGetPlayerShips>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }

        public static ServiceData GetPlayerMissedShips(string tableName, string playerName)
        {
            ServiceData serviceData = new ServiceData();

            ServiceResponse response = RequestSender.Get(
                "/ships/all/missed",
                $@"?tableName={tableName}&playerName={playerName}"
            ).Result;

            if (response.StausCode != 200)
            {
                serviceData.Data = JsonConvert.DeserializeObject<InfoResponse>(response.ResponseJson);
                serviceData.StausCode = response.StausCode;
                return serviceData;
            }
            serviceData.Data = JsonConvert.DeserializeObject<SuccessGetPlayerShips>(response.ResponseJson);
            serviceData.StausCode = response.StausCode;

            return serviceData;
        }

        public static ServiceData GetPlayerTour(string gameCode)
        {
            ServiceData serviceData = new ServiceData();

            ServiceResponse response = RequestSender.Get(
                "/player/tour",
                $@"?tableName={gameCode}"
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

        public static ServiceData DestroyShip(DestroyShip bodyData)
        {
            ServiceData serviceData = new ServiceData();
            string jsonBody = JsonConvert.SerializeObject(bodyData);

            ServiceResponse response = RequestSender.Put("/ships/destroy", jsonBody).Result;

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

        public static ServiceData SetPlayerTour(SetPlayerTour bodyData)
        {
            ServiceData serviceData = new ServiceData();
            string jsonBody = JsonConvert.SerializeObject(bodyData);

            ServiceResponse response = RequestSender.Put("/player/tour", jsonBody).Result;

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
    }
}
