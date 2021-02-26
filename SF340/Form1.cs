using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF340
{
    public partial class Form1 : Form
    {
        public string answer = "";
        private int max;
        public Form1()
        {
            InitializeComponent();
            SQLiteConnection con = new SQLiteConnection(@"data source=D:\SF340\SF340\SF340\Vocab.db");
            con.Open();


        }


        private void button_Click(object sender, EventArgs e)
        {

        }

        private void setQuestion(SQLiteConnection con)
        {
            Random rand = new Random();
            int a, b, c, d;
            do
            {
                a = rand.Next(1, max);
                b = rand.Next(1, max);
                c = rand.Next(1, max);
                d = rand.Next(1, max);
            } while ((a == b) || (b == c) || (a == c));

            string query = "Select word1 from synnonym";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
        }
    }
}
