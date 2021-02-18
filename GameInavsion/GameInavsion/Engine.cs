using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInavsion
{
    class Engine
    {
        Form1 ths;
        login_form _login_form = new login_form();
        public Engine(Form1 _form1)
        {
            ths = _form1;
        }
        public void ColiziuneMunitieInamicPlayer()
        {
            for (int i = 0; i < Date.munitie_inamici.Length; i++)
            {
                if (Date.munitie_inamici[i].Bounds.IntersectsWith(ths.Player.Bounds))
                {
                    Date.munitie_inamici[i].Visible = false;
                    Sunet.SunetJocTerminatControlPlay();
                    ths.Player.Visible = false;
                    Trace.TraceInformation(Date.username_player_actual + " : A fost omorat de inmaic - Scor : " + Date.scor);
                    Game_over("AI PIERDUT!");
                }
            }
        }
        public void ColiziuneMunitiePlayerInamic()
        {
            
            for (int i = 0; i < Date.inamici.Length; i++)
            {
                
                if (Date.munitie[0].Bounds.IntersectsWith(Date.inamici[i].Bounds) || Date.munitie[1].Bounds.IntersectsWith(Date.inamici[i].Bounds) || Date.munitie[2].Bounds.IntersectsWith(Date.inamici[i].Bounds))
                {
                    
                    Sunet.SunetExplozieControlPlay();
                    
                    Date.scor += 1;
                    Trace.TraceInformation(Date.username_player_actual + " : A uscis un inamic - Scor : " + Date.scor);

                    ths.Scorlbl.Text = (Date.scor < 10) ? "0" + Date.scor.ToString() : Date.scor.ToString();
                    //MessageBox.Show(Date.scor.ToString());
                    if (Date.scor % 30 == 0)
                    {
                        Date.level += 1;
                        
                        ths.levellbl.Text = (Date.level < 10) ? "0" + Date.level.ToString() : Date.level.ToString();

                        if (Date.viteza_inamici <= 10 && Date.viteza_munitie_inamici <= 10 && Date.dificultate >= 0)
                        {
                            Date.dificultate--;
                            Date.viteza_inamici++;
                            Date.viteza_munitie_inamici++;
                        }
                        if (Date.level == 10)
                        {
                            Trace.TraceInformation(Date.username_player_actual + " : A castigat - Scor : " + Date.scor);
                            Game_over("Ai castigat!");

                        }
                    }
                    Date.inamici[i].Location = new Point((i + 1) * 50, -100);

                }
                if (ths.Player.Bounds.IntersectsWith(Date.inamici[i].Bounds))
                {
                    Sunet.SunetJocTerminatControlPlay();
                    ths.Player.Visible = false;
                    Trace.TraceInformation(Date.username_player_actual + " : S-a ciocnit cu un inamic - Scor : " + Date.scor);
                    Game_over("AI PIERDUT!");

                }
            }
        }
        public void Game_over(string str)
        {
           ths.label1.Text = str;
            ths.label1.Location = new Point(ths.Width / 2 - 160, 50);
            ths.label1.Visible = true;
            ths.Iesire_button.Visible = true;
            ths.Replay_button.Visible = true;
            ths.score_button.Visible = true;
            _login_form.ActualizareScor();
            
            //MessageBox.Show(Date.scor.ToString());
            Sunet.MuzicaJocControlStop();
            Stop_miscari();
            
        }
        public void Stop_miscari()
        {
            ths.Miscare_dreapta.Stop();
            ths.Miscare_stanga.Stop();
            ths.Miscare_sus.Stop();
            ths.Miscare_jos.Stop();
            ths.Miscare_fundal_timer.Stop();
            ths.Miscare_inamici.Stop();
            ths.Miscare_munitie.Stop();
            ths.Miscare_munitie_inamici.Stop();
        }
        public void Start_miscari()
        {
            ths.Miscare_fundal_timer.Start();
            ths.Miscare_inamici.Start();
            ths.Miscare_munitie.Start();
            ths.Miscare_munitie_inamici.Start();
        }
    }
}
