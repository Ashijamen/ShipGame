using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipGame.Properties;
using System.Diagnostics;


namespace shipgame1
{
    public partial class Form1 : Form
    {


        public List<Point> PozycjaGraczaButtonPoint;
        public List<Point> PozycjaPrzeciwnikaButtonPoint;


        Random rand = new Random();

        int TotalShip = 3;
        int round = 10;
        int playerScore;
        int EnemyScore;

        public class Point
        {
            public int? x { get; set; } // Współrzędne x i y punktu.
            public int? y { get; set; }
            public bool Enabled { get; set; } //Określa, czy punkt jest włączony (aktywny) na planszy.
            public string Tag { get; set; } //Dowolna etykieta lub tag przypisany do punktu.
            public Color BackColor { get; set; } //Kolor tła punktu.
            public string Text { get; set; } //Tekst wyświetlany na punkcie.
            public Image BackgroundImage { get; internal set; } //Obrazek tła punktu.
            public string Name { get; set; } //Nazwa punktu.




        }


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void EnemyPlayTimeEvent(object sender, EventArgs e)
        {

            if (PozycjaGraczaButtonPoint.Count > 0 && round > 0)
            {
                round -= 1;

                txtRundy.Text = "Round: " + round;

                int index = rand.Next(PozycjaGraczaButtonPoint.Count);

                if ((string)PozycjaGraczaButtonPoint[index].Tag == "playerShip")
                {
                    PozycjaGraczaButtonPoint[index].BackgroundImage = Properties.Resources.fire;
                    ruchWroga.Text = PozycjaGraczaButtonPoint[index].Text;
                    PozycjaGraczaButtonPoint[index].Enabled = false;
                    PozycjaGraczaButtonPoint[index].BackColor = Color.DarkBlue;
                    PozycjaGraczaButtonPoint.RemoveAt(index);
                    EnemyScore += 1;
                    txtPrzeciwnik.Text = EnemyScore.ToString();
                    CzasGryWroga.Stop();
                }
                else
                {
                    PozycjaGraczaButtonPoint[index].BackgroundImage = shipgame1.Properties.Resources.shotx;
                    ruchWroga.Text = PozycjaGraczaButtonPoint[index].Text;
                    PozycjaGraczaButtonPoint[index].Enabled = false;
                    PozycjaGraczaButtonPoint[index].BackColor = Color.DarkBlue;
                    PozycjaGraczaButtonPoint.RemoveAt(index);
                    CzasGryWroga.Stop();
                }
            }

            if (round < 1 || EnemyScore > 2 || playerScore > 2)
            {

                if (playerScore > EnemyScore)
                {
                    MessageBox.Show("WYGRAŁEŚ!!", "Winning");
                    RestartGame();
                }
                else if (EnemyScore > playerScore)
                {
                    MessageBox.Show("Haha, przegrałeś", "Lost");
                    RestartGame();
                }
                else if (EnemyScore == playerScore)
                {
                    MessageBox.Show("remis", "Draw");
                    RestartGame();
                }
            }



        }

        private void AtakButtonEvent(object sender, EventArgs e)
        {
            if (PolePrzeciwnikaListaBox.Text != "")
            {

                var attackPosition = PolePrzeciwnikaListaBox.Text.ToLower();

                int index = PozycjaPrzeciwnikaButtonPoint.FindIndex(a => a.Text == attackPosition);

                if (PozycjaPrzeciwnikaButtonPoint[index].Enabled && round > 0)
                {
                    round -= 1;
                    txtRundy.Text = "Round: " + round;


                    if ((string)PozycjaPrzeciwnikaButtonPoint[index].Tag == "enemyShip")
                    {

                        PozycjaPrzeciwnikaButtonPoint[index].Enabled = false;
                        PozycjaPrzeciwnikaButtonPoint[index].BackgroundImage = Properties.Resources.fire;
                        PozycjaPrzeciwnikaButtonPoint[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtGracz.Text = playerScore.ToString();
                        CzasGryWroga.Start();

                    }
                    else
                    {
                        PozycjaPrzeciwnikaButtonPoint[index].Enabled = false;
                        PozycjaPrzeciwnikaButtonPoint[index].BackgroundImage = Properties.Resources.shotx;
                        PozycjaPrzeciwnikaButtonPoint[index].BackColor = Color.DarkBlue;
                        CzasGryWroga.Start();
                    }


                }


            }
            else
            {
                MessageBox.Show("Choose a location from the drop down first", "Information");
            }
        }

        private void PozycjaGraczaButtonEvents(object sender, EventArgs e)
        {

            if (TotalShip > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Orange;
                TotalShip -= 1;
            }

            if (TotalShip == 0)
            {
                btnAtak.Enabled = true;
                btnAtak.BackColor = Color.Red;
                btnAtak.ForeColor = Color.White;


            }


        }


        private void RestartGame()
        {

            PozycjaGraczaButtonPoint = new List<Point>();
            PozycjaGraczaButtonPoint.Add(new Point() { x = 1, y = 1, Text = "a1" }); /*a1*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 1, y = 2, Text = "a2" }); /*a2*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 1, y = 3, Text = "a3" }); /*a3*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 1, y = 4, Text = "a3" }); /*a4*/

            PozycjaGraczaButtonPoint.Add(new Point() { x = 2, y = 1, Text = "b1" }); /*a1*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 2, y = 2, Text = "b2" }); /*a2*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 2, y = 3, Text = "b3" }); /*a3*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 2, y = 4, Text = "b4" }); /*a4*/

            PozycjaGraczaButtonPoint.Add(new Point() { x = 3, y = 1, Text = "c1" }); /*a1*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 3, y = 2, Text = "c2" }); /*a2*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 3, y = 3, Text = "c3" }); /*a3*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 3, y = 4, Text = "c4" }); /*a4*/

            PozycjaGraczaButtonPoint.Add(new Point() { x = 4, y = 1, Text = "d1" }); /*a1*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 4, y = 2, Text = "d2" }); /*a2*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 4, y = 3, Text = "d3" }); /*a3*/
            PozycjaGraczaButtonPoint.Add(new Point() { x = 4, y = 4, Text = "d4" }); /*a4*/
            PozycjaPrzeciwnikaButtonPoint = new List<Point>();
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 1, y = 1, Text = "ax1" }); /*a1*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 2, y = 1, Text = "ax2" }); /*ax2*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 3, y = 1, Text = "ax3" }); /*ax3*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 4, y = 1, Text = "ax4" }); /*ax4*/

            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 1, y = 2, Text = "bx1" }); /*a1*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 2, y = 2, Text = "bx2" }); /*a2*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 3, y = 2, Text = "bx2" }); /*a3*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 4, y = 2, Text = "bx3" }); /*a4*/

            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 1, y = 3, Text = "cx1" }); /*a1*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 2, y = 3, Text = "cx2" }); /*a2*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 3, y = 3, Text = "cx3" }); /*a3*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 4, y = 3, Text = "cx4" }); /*a4*/

            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 1, y = 4, Text = "dx1" }); /*a1*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 2, y = 4, Text = "dx2" }); /*a2*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 3, y = 4, Text = "dx3" }); /*a3*/
            PozycjaPrzeciwnikaButtonPoint.Add(new Point() { x = 4, y = 4, Text = "dx4" }); /*a4*/

            PolePrzeciwnikaListaBox.Items.Clear();

            PolePrzeciwnikaListaBox.Text = null;


            for (int i = 0; i < PozycjaPrzeciwnikaButtonPoint.Count; i++)
            {
                PozycjaPrzeciwnikaButtonPoint[i].Enabled = true;
                PozycjaPrzeciwnikaButtonPoint[i].Tag = null;
                PozycjaPrzeciwnikaButtonPoint[i].BackColor = Color.White;
                PozycjaPrzeciwnikaButtonPoint[i].BackgroundImage = null;
                PolePrzeciwnikaListaBox.Items.Add(PozycjaPrzeciwnikaButtonPoint[i].Text);
            }

            for (int i = 0; i < PozycjaGraczaButtonPoint.Count; i++)
            {
                PozycjaGraczaButtonPoint[i].Enabled = true;
                PozycjaGraczaButtonPoint[i].Tag = null;
                PozycjaGraczaButtonPoint[i].BackColor = Color.White;
                PozycjaGraczaButtonPoint[i].BackgroundImage = null;
            }

            playerScore = 0;
            EnemyScore = 0;
            round = 10;
            TotalShip = 3;

            txtGracz.Text = playerScore.ToString();
            txtPrzeciwnik.Text = EnemyScore.ToString();
            ruchWroga.Text = "A1";

            btnAtak.Enabled = false;

            EnemyLocationPicker();


        }

        private void EnemyLocationPicker()
        {

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(PozycjaPrzeciwnikaButtonPoint.Count);

                if (PozycjaPrzeciwnikaButtonPoint[index].Enabled == true && (string)PozycjaPrzeciwnikaButtonPoint[index].Tag == null)
                {
                    PozycjaPrzeciwnikaButtonPoint[index].Tag = "enemyShip";

                    Debug.WriteLine("Enemy Position: " + PozycjaPrzeciwnikaButtonPoint[index].Text);
                }
                else
                {
                    index = rand.Next(PozycjaPrzeciwnikaButtonPoint.Count);
                }
            }


        }
    }
}