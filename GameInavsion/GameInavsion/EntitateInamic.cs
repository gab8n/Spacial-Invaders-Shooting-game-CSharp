using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInavsion
{
    public class EntitateInamic
    {
        Form1 ths;
         

        

        public EntitateInamic(Form1 _form1)
        {
            ths = _form1;
            

           


        }
        public  void Generare()
        {
            
            for (int i = 0; i < Date.inamici.Length; i++)
            {

                Date.inamici[i] = new PictureBox();
                Date.inamici[i].Size = new Size(40, 40);
                //inamici[i].BackColor = Color.Transparent;
                Date.inamici[i].SizeMode = PictureBoxSizeMode.Zoom;
                Date.inamici[i].BorderStyle = BorderStyle.None;
                Date.inamici[i].Visible = false;
                //Form1.Controls.Add(inamici[i]);
                //inamici[i].Location = new Point((i + 1) * 50, -50);
                Date.inamici[i].Location = new Point((i + 1) * 50, -50);
                ths.Controls.Add(Date.inamici[i]);
            }
            Date.GenerareImaginiInamici();

        }
        
        public static void MiscareInamici( int _heigh)
        {
            for (int i = 0; i < Date.inamici.Length; i++)
            {
                Date.inamici[i].Visible = true;
                Date.inamici[i].Top += Date.viteza_inamici;
                if (Date.inamici[i].Top > _heigh)
                {
                    Date.inamici[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        public  void GenerareMunitieInamici(int x)
        {
            for (int i = 0; i < Date.munitie_inamici.Length; i++)
            {
                Date.munitie_inamici[i] = new PictureBox();
                Date.munitie_inamici[i].Size = new Size(2, 25);
                Date.munitie_inamici[i].Visible = false;
                Date.munitie_inamici[i].BackColor = Color.Yellow;
                Date.munitie_inamici[i].Location = new Point(Date.inamici[x].Location.X, Date.inamici[x].Location.Y - 20);
                ths.Controls.Add(Date.munitie_inamici[i]);

            }
        }
        public void MiscareMunitieInamici(int x)
        {
            for (int i = 0; i < (Date.munitie_inamici.Length - Date.dificultate); i++)
            {
                if (Date.munitie_inamici[i].Top < ths.Height)
                {
                    Date.munitie_inamici[i].Visible = true;
                    Date.munitie_inamici[i].Top += Date.viteza_munitie_inamici;
                    new Engine(ths).ColiziuneMunitieInamicPlayer();
                }
                else
                {
                    Date.munitie_inamici[i].Visible = false;

                    Date.munitie_inamici[i].Location = new Point(Date.inamici[x].Location.X + 20, Date.inamici[x].Location.Y + 30);
                }

            }
        }
    }
}
