using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInavsion
{
    public class Fundal
    {
        public static Random rnd;
        
        Form1 ths;
        public Fundal(Form1 _form1)
        {
            ths = _form1;
            
            rnd = new Random();
        }
        public  void GenerareStele()
        {
            for (int i = 0; i < Date.stele.Length; i++)
            {
                Date.stele[i] = new PictureBox();
                Date.stele[i].BorderStyle = BorderStyle.None;
                Date.stele[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    Date.stele[i].Size = new Size(2, 2);
                    Date.stele[i].BackColor = Color.Wheat;
                }
                else
                {
                    Date.stele[i].Size = new Size(3, 3);
                    Date.stele[i].BackColor = Color.DarkGray;
                }
                ths.Controls.Add(Date.stele[i]);
            }
        }
        public  void GenerareSteleMiciMari(int _heigh)
        {
            for (int i = 0; i < Date.stele.Length / 2; i++)
            {
                Date.stele[i].Top += Date.viteza_fundal;
                if (Date.stele[i].Top >= _heigh)
                {
                    Date.stele[i].Top = -Date.stele[i].Height;
                }
            }
            for (int i = Date.stele.Length / 2; i < Date.stele.Length; i++)
            {
                Date.stele[i].Top += Date.viteza_fundal - 2;
                if (Date.stele[i].Top >= _heigh)
                {
                    Date.stele[i].Top = -Date.stele[i].Height;
                }
            }
        }
    }
    
}
