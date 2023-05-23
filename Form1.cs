using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;


namespace ShipGame
{

    public partial class Form1 : Form
    {
        List<Button> PolaPrzeciwnikaListabtn;
        List<Button> PolaGraczaLista;

        Random rand = new Random();

        int totalShip = 3;
        int round = 10;
        int playerScore;
        int enemyScore;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        private void CzasGraniaPrzeciwnika(object sender, EventArgs e)
        {

        }

        private void AtakBtn(object sender, EventArgs e)
        {

        }

        private void PozycjaGraczaBtn(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            List<Point> PolaGraczaLista = new List<Point>();
            PolaGraczaLista.Add(new Point() { x = 1, y = 1 }); /*a1*/
            PolaGraczaLista.Add(new Point() { x = 2, y = 1 }); /*a2*/
            PolaGraczaLista.Add(new Point() { x = 3, y = 1 }); /*a3*/
            PolaGraczaLista.Add(new Point() { x = 4, y = 1 }); /*a4*/

            PolaGraczaLista.Add(new Point() { x = 1, y = 2 }); /*b1*/
            PolaGraczaLista.Add(new Point() { x = 2, y = 2 }); /*b2*/
            PolaGraczaLista.Add(new Point() { x = 3, y = 2 }); /*b3*/
            PolaGraczaLista.Add(new Point() { x = 4, y = 2 }); /*b4*/

            PolaGraczaLista.Add(new Point() { x = 1, y = 3 }); /*c1*/
            PolaGraczaLista.Add(new Point() { x = 2, y = 3 }); /*c2*/
            PolaGraczaLista.Add(new Point() { x = 3, y = 3 }); /*c3*/
            PolaGraczaLista.Add(new Point() { x = 4, y = 3 }); /*c4*/

            PolaGraczaLista.Add(new Point() { x = 1, y = 4 }); /*d1*/
            PolaGraczaLista.Add(new Point() { x = 2, y = 4 }); /*d2*/
            PolaGraczaLista.Add(new Point() { x = 3, y = 4 }); /*d3*/
            PolaGraczaLista.Add(new Point() { x = 4, y = 4 }); /*d4*/




            

            /*            PolaPrzeciwnikaListabtn = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };
                        PolaGraczaLista = new List<Button> { ax1, ax2, ax3, ax4, bx1, bx2, bx3, bx4, cx1, cx2, cx3, cx4, dx1, dx2, dx3, dx4 };


                        PolaPrzeciwnikaLista.Items.Clear();
                        PolaPrzeciwnikaLista.Text = null;

                        *//* pętla aby wypisac pola gracza - lista*//*



                        for (int i = 0; i < PolaGraczaLista.Count; i++)
                        {

                        }*/




            /*            List<Point> PolaPrzeciwnikaLista = new List<Point>();
                        PolaPrzeciwnikaLista.Add(new Point(a1, ax1));
                        PolaPrzeciwnikaLista.Add(new Point(a2, ax2));



                        foreach (var PolaPrzeciwnika in PolaPrzeciwnikaLista)
                        {
                            Console.WriteLine(PolaPrzeciwnika);

                        }*/
            /*
                        List<Point> PolaPrzeciwnikaLista = new List<Point>();
                        PolaPrzeciwnikaLista.Add(new Point(0, ax1)); // dodanie punktu (0, 0) do listy
                        foreach (var PolaPrzeciwnika in PolaPrzeciwnikaLista)
                        {
                            Console.WriteLine(PolaPrzeciwnika);
                        }*/

            /*PolaPrzeciwnikaLista = new List<Button> {a1};*/









        }
        

        private void LozalizacjaPrzeciwnika()
        {

        }

    }
}
