using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipGame
{
    public partial class menu_gry : Form
    {
        public menu_gry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*
            string UserInputSave = TextBox.Text;
            label2.text = UserInputSave;*/
        }
        public class AddPlayer
        {
            public string tableName { get; set; }
            public string playerName { get; set; }
            public List<Point> ships { get; set; }


        }


    }
}
