using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInavsion
{
    public partial class Lista : Form
    {
        login_form _login_form = new login_form();
        public Lista()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("id", 250);
            listView1.Columns.Add("nume", 250);
            listView1.Columns.Add("scor", 250);
        }

        public void Lista_Load(object sender, EventArgs e)
        {

        }

        public void GenerareListView()
        {
            _login_form.ConectareBazaDeDate();
            string stmt = "SELECT * FROM LoginScore";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _login_form._conexiune);
            SQLiteDataReader reader = null;
            reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                string _nume = (string)reader["User"];
                string _id = Convert.ToString(reader["id"]);
                string _scor = Convert.ToString(reader["Score"]);
                //MessageBox.Show(_id + _nume + _scor)
                string[] row = { _id, _nume, _scor };

                ListViewItem lvi = new ListViewItem(row);
                //Trace.TraceInformation(lvi.Text);



                listView1.Items.Add(lvi);
                //Trace.TraceInformation("trece");

                //MessageBox.Show(reader.GetValue(1) + " " + reader.GetValue(2) + " " + reader.GetValue(3) + " " + '\n');


            }





        }
    }
}
