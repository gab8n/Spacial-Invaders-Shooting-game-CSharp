using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInavsion
{
    public class EntitatePlayer
    {
         Form1 ths;

        

        public EntitatePlayer(Form1 _form1)
        {
            
            
            ths = _form1;
        }
        public   void MiscareSus()
        {
            if (ths.Player.Top > 10)
            {
                ths.Player.Top -= Date.viteza_player;
            }
        }
        public void MiscareJos()
        {
            if (ths.Player.Top < 400)
            {
                ths.Player.Top += Date.viteza_player;
            }
        }
        public void MiscareDreapta()
        {
            if (ths.Player.Right < 580)
            {
                ths.Player.Left += Date.viteza_player;
            }
        }
        public void MiscareStanga()
        {
            if (ths.Player.Left > 10)
            {
                ths.Player.Left -= Date.viteza_player;
            }
        }
        public void GenerareMunitiePlayer()
        {
            for (int i = 0; i < Date.munitie.Length; i++)
            {
                Date.munitie[i] = new PictureBox();
                Date.munitie[i].Size = new Size(8, 8);
                Date.munitie[i].Image = Date.munitie_player;
                Date.munitie[i].SizeMode = PictureBoxSizeMode.Zoom;
                Date.munitie[i].BorderStyle = BorderStyle.None;
               ths.Controls.Add(Date.munitie[i]);
            }
        }
        public void MiscareMunitiePlayer()
        {
            Sunet.SunetMunitieControlPlay();
            for (int i = 0; i < Date.munitie.Length; i++)
            {
                if (Date.munitie[i].Top > 0)
                {

                    Date.munitie[i].Visible = true;
                    Date.munitie[i].Top -= Date.viteza_munitie;
                    
                    new Engine(ths).ColiziuneMunitiePlayerInamic();
                }
                else
                {
                    Date.munitie[i].Visible = false;
                    Date.munitie[i].Location = new Point(ths.Player.Location.X + 20, ths.Player.Location.Y - i * 30);
                }
            }
        }
    }
}
