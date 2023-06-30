using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ShipGame
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //To show how works api

            //Create request body
            CreateGame testRequest = new CreateGame();
            testRequest.playerName = "newPlayerOne";

            List<Point> playerShips = new List<Point>();

            for (int i = 0; i < 10; i++)
            {
                Point testPoint1 = new Point();
                testPoint1.x = 1;
                testPoint1.y = i + 1;
                playerShips.Add(testPoint1);
            }

            testRequest.ships = playerShips;
            // send to backend
            var response = BackendApi.CreateGame(testRequest);
            //check if staus code is 200
            //if status code is not 200 response is instance of InfoResponse
            // if game created succesfully
            if (response.StausCode == 200)
            {
                Console.WriteLine(response.Data.NewGameCode);
                AddPlayer player2Request = new AddPlayer()
                {
                    tableName = response.Data.NewGameCode,
                    playerName = "test2",
                    ships = playerShips
                };
                var responsePlayer2 = BackendApi.AddPlayerTwo(player2Request);
                Console.WriteLine(responsePlayer2.StausCode);
                SetPlayerTour testPutData = new SetPlayerTour()
                {
                    tableName = response.Data.NewGameCode,
                    playerName = "test2",
                };
                //get example
                ServiceData playerIndex = BackendApi.GetPlayerId(response.Data.NewGameCode, testPutData.playerName);
                Console.WriteLine(playerIndex.Data.playerIndex);
            }
            else
            {
                Console.WriteLine(response.Data.ErrorCode);

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
