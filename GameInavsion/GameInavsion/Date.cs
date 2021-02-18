using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameInavsion
{
    public class Date
    {
        public static int viteza_munitie_inamici;
        public static int viteza_fundal;
        public static int viteza_player;
        public static int viteza_munitie;
        public static int viteza_inamici;
        public static int scor;
        public static int level;
        public static int dificultate;
        public static bool pauza;
        public static bool gameover;
        public static string username_player_actual;
        public static int x;

        

        public static Image munitie_player = Image.FromFile(@"asserts\munition.png");
        public static Image inamic1 = Image.FromFile(@"asserts\\E1.png");
        public static Image inamic2 = Image.FromFile(@"asserts\\E2.png");
        public static Image inamic3 = Image.FromFile(@"asserts\\E3.png");
        public static Image boss1 = Image.FromFile(@"asserts\\Boss1.png");
        public static Image boss2 = Image.FromFile(@"asserts\\Boss2.png");
        public static PictureBox[] munitie = new PictureBox[3];
        public static PictureBox[] inamici = new PictureBox[10];
        public static PictureBox[] stele = new PictureBox[18];
        public static PictureBox[] munitie_inamici = new PictureBox[10];

        public Date()
        {
            CitireXML();

        }
        public static void GenerareImaginiInamici()
        {
            Date.inamici[0].Image = Date.boss1;
            Date.inamici[1].Image = Date.inamic3;
            Date.inamici[2].Image = Date.inamic2;
            Date.inamici[3].Image = Date.inamic2;
            Date.inamici[4].Image = Date.inamic2;
            Date.inamici[5].Image = Date.inamic1;
            Date.inamici[6].Image = Date.inamic1;
            Date.inamici[7].Image = Date.inamic3;
            Date.inamici[8].Image = Date.inamic3;
            Date.inamici[9].Image = Date.boss2;

        }
        public static void CitireXML()
        {
            
            XmlTextReader _xtr = new XmlTextReader(@"C:\Users\Gab8n\Desktop\Spacial Invaders\GameInavsion\GameInavsion\DateConstante.xml");
           while(_xtr.Read())
            {
                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "viteza_munitie_inamici")
                {
                    viteza_munitie_inamici = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "viteza_fundal")
                {
                    viteza_fundal = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "viteza_player")
                {
                    viteza_player = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "viteza_munitie")
                {
                    viteza_munitie = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "viteza_inamici")
                {
                    viteza_inamici = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "scor")
                {
                    scor = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "level")
                {
                    level = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "dificultate")
                {
                    dificultate = int.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "pauza")
                {
                    pauza = bool.Parse(_xtr.ReadElementContentAsString());
                }

                if (_xtr.NodeType == XmlNodeType.Element && _xtr.Name == "gameover")
                {
                    gameover = bool.Parse(_xtr.ReadElementContentAsString());
                }

                //string ceva =  _xtr.ReadString();
               
                //int nume = Convert.ToInt32(ceva);
                //Console.WriteLine(nume);
            }
        }
    }
}
