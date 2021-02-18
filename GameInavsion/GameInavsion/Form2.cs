using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace GameInavsion
{
    public partial class login_form : Form
    {
        public SQLiteConnection _conexiune;
        
        public login_form()
        {
            


            InitializeComponent();
            
        }
        public void StartSplashScreen()
        {
            Application.Run(new SplashScreen());
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            Date.CitireXML();
            ConectareBazaDeDate();
            Date.username_player_actual = user_textbox.Text;
            string password = password_textbox.Text;
           
            int scor = 0;
           
            if (VerificaUser(Date.username_player_actual) == true)
            {
                if (GasireParola(Date.username_player_actual) == password)
                {
                    this.Hide();
                    Thread _thread = new Thread(new ThreadStart(StartSplashScreen));
                    _thread.Start();
                    Thread.Sleep(6000);
                    Form1 _form1 = new Form1();
                    _form1.Show();
                    _thread.Abort();
                    Trace.TraceInformation(Date.username_player_actual + " : S-a conectat - Scor : " + Date.scor);
                }
                else
                    MessageBox.Show("Parola Incorecta");
            }
            else
            {
                MessageBox.Show("Nou Jucator Gasit!");
                Trace.TraceInformation(Date.username_player_actual + " : S-a conectat pentru prima data - Scor : " + Date.scor);
                NouJucator(Date.username_player_actual, password, scor);
                this.Hide();
                Thread _thread = new Thread(new ThreadStart(StartSplashScreen));
                _thread.Start();
                Thread.Sleep(6000);
                Form1 _form1 = new Form1();
                _form1.Show();
                _thread.Abort();
            }
           
            
        }
        

        private void login_form_Load(object sender, EventArgs e)
        {

        }
        public void ConectareBazaDeDate()
        {
            if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
            }
            
                _conexiune = new SQLiteConnection("DataSource=MyDatabase.sqlite;Version=3;");
                _conexiune.Open();
                string stmt = "CREATE TABLE IF NOT EXISTS LoginScore(id INTEGER PRIMARY KEY AUTOINCREMENT, User TEXT, Password TEXT, Score int)";
                SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
                //MessageBox.Show("Conectare Reusita");
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create table! ERROR:" + ex.ToString());
                    return;
                }
           
            


        }
        public bool VerificaUser(string username)
        {
            string stmt = "SELECT COUNT(*) FROM LoginScore WHERE User='" + username + "'";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
        
            
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                if (a > 0)
                    return true;
                else
                    return false;

            
            
        }
        public void NouJucator(string User, string Password, int Score)
        {
            string stmt = "INSERT INTO LoginScore(User, Password, Score) VALUES ('" + User + "', '" + Password + "', '" + Score + "')";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
            cmd.ExecuteNonQuery();
            
     
              
        }
        public string GasireParola(string username)
        {

            string password = null;
            string stmt = "SELECT Password FROM LoginScore WHERE User='" + username + "'";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
            SQLiteDataReader reader = null;
            
            
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                password = reader.GetString(0);
            }
            reader.Close();
            return password;
        }
        public void ActualizareScor()
        {
            ConectareBazaDeDate();
            //MessageBox.Show(scor.ToString());
            string username = user_textbox.Text;
            string stmt = "UPDATE LoginScore SET Score='" + Date.scor + "' WHERE User='" + Date.username_player_actual + "'";
            //string stmt = "DELETE FROM LoginScore";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
            cmd.Connection = _conexiune;
            cmd.ExecuteNonQuery();
            if (null != _conexiune)
            {

                _conexiune.Close();
                _conexiune.Dispose();
                _conexiune = null;
                
            }
   
        }
        public void SortareScoruri()
        {
            ConectareBazaDeDate();
            
            
            string stmt = "SELECT User , Password , Score From LoginScore ORDER BY Score DESC";
            //string stmt = "DELETE FROM LoginScore";
            SQLiteCommand cmd = new SQLiteCommand(stmt, _conexiune);
            cmd.Connection = _conexiune;
            cmd.ExecuteNonQuery();
            if (null != _conexiune)
            {

                _conexiune.Close();
                _conexiune.Dispose();
                _conexiune = null;

            }
        }
        
    }
}
