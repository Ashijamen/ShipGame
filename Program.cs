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
        /// test
        [STAThread]
        static void Main()
        {
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
            var response = BackendApi.CreateGame(testRequest);
            // if game created succesfully
            if(response.StausCode == 200)
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
                ServiceData player2Tour = BackendApi.GetPlayerTour(response.Data.NewGameCode, player2Request.playerName);
                Console.WriteLine(player2Tour.Data.playerIndex);
            }
            else
            {
                Console.WriteLine(response.Data.ErrorCode);

            }

            Console.WriteLine(RequestSender.Get("/player/tour", "?tableName=ravzavgkkv").Result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
