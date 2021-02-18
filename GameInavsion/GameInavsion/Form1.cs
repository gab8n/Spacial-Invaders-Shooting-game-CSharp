using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GameInavsion
{
    public partial class Form1 : Form
    {
        Sunet _sunet = new Sunet();
        
        login_form _login_form = new login_form();
        
        
        
        
  
        Random rnd;
 
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            //this.DoubleBuffered = true;

            //Date.ImaginiInamici();



            new EntitateInamic(this).Generare();
            



            new EntitatePlayer(this).GenerareMunitiePlayer();

            rnd = new Random();
          new Fundal(this).GenerareStele();

            
            int x = rnd.Next(0, 10);
            new EntitateInamic(this).GenerareMunitieInamici(x);

            Sunet.MuzicaJocControlPlay();
     
        }
        
        private void Miscare_fundal_timer_Tick(object sender, EventArgs e)
        {

            new Fundal(this).GenerareSteleMiciMari(this.Height);
        }
        
        private void Miscare_stanga_Tick(object sender, EventArgs e)
        {
            new EntitatePlayer(this).MiscareStanga();
        }

        private void Miscare_dreapta_Tick(object sender, EventArgs e)
        {
            new EntitatePlayer(this).MiscareDreapta();

        }

        private void Miscare_jos_Tick(object sender, EventArgs e)
        {
            new EntitatePlayer(this).MiscareJos();
        }

        private void Miscare_sus_Tick(object sender, EventArgs e)
        {
            new EntitatePlayer(this).MiscareSus();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Date.pauza)
            {
                if (e.KeyCode == Keys.W)
                {
                    Miscare_sus.Start();
                }
                if (e.KeyCode == Keys.S)
                {
                    Miscare_jos.Start();
                }
                if (e.KeyCode == Keys.A)
                {
                    Miscare_stanga.Start();
                }
                if (e.KeyCode == Keys.D)
                {
                    Miscare_dreapta.Start();
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Miscare_dreapta.Stop();
            Miscare_stanga.Stop();
            Miscare_sus.Stop();
            Miscare_jos.Stop();
            if (e.KeyCode == Keys.P)
            {
                if (!Date.gameover)
                {
                    if (Date.pauza)
                    {
                        new Engine(this).Start_miscari();
                        label1.Visible = false;
                        Iesire_button.Visible = false;
                        score_button.Visible = false;
                        Sunet.MuzicaJocControlPlay();
                        Date.pauza = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "PAUZA";
                        label1.Visible = true;
                        Iesire_button.Visible = true;
                        score_button.Visible = true;
                        Trace.TraceInformation(Date.username_player_actual + " : A pus pauza - Scor : " + Date.scor);

                        Sunet.MuzicaJocControlPause();
                        new Engine(this).Stop_miscari();
                        Date.pauza = true;
                    }
                }
            }

           

        }

        private void Miscare_munitie_Tick(object sender, EventArgs e)
        {
            new EntitatePlayer(this).MiscareMunitiePlayer();

        }
        
        
            
        private void Miscare_inamici_Tick(object sender, EventArgs e)
        {

            EntitateInamic.MiscareInamici(this.Height);
        }
        
        
        

        private void Miscare_munitie_inamici_Tick(object sender, EventArgs e)
        {
            int x = rnd.Next(0, 10);
            new EntitateInamic(this).MiscareMunitieInamici( x);

        }
 
        private void Replay_button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Iesire_button_Click(object sender, EventArgs e)
        {
            Trace.TraceInformation(Date.username_player_actual + " : A inchis jocul - Scor : " + Date.scor);
            Environment.Exit(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void score_button_Click(object sender, EventArgs e)
        {
            Lista _lista = new Lista();
            _login_form.SortareScoruri();
            _lista.GenerareListView();
            _lista.Show();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
