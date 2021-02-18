using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace GameInavsion
{
    class Sunet
    {
        public static WindowsMediaPlayer muzica_joc;
        public static WindowsMediaPlayer sunet_munitie;
        public static WindowsMediaPlayer explozie;
        public static WindowsMediaPlayer game_over;
        public Sunet()
        {
            muzica_joc = new WindowsMediaPlayer();
            muzica_joc.URL = "songs\\GameSong.mp3";
            muzica_joc.settings.setMode("loop", true);
            muzica_joc.settings.volume = 5;

            sunet_munitie = new WindowsMediaPlayer();
            sunet_munitie.URL = "songs\\shoot.mp3";
            sunet_munitie.settings.volume = 3;

            explozie = new WindowsMediaPlayer();
            explozie.URL = "songs\\boom.mp3";
            explozie.settings.volume = 6;

            game_over = new WindowsMediaPlayer();
            game_over.URL = "songs\\GameOver.mp3";
            game_over.settings.volume = 30;

        }
        public static  void MuzicaJocControlPlay()
        {
            muzica_joc.controls.play();
        }
        public static void MuzicaJocControlPause()
        {
            muzica_joc.controls.pause();
        }
        public static void MuzicaJocControlStop()
        {
            muzica_joc.controls.stop();
        }
        public static void SunetMunitieControlPlay()
        {
            sunet_munitie.controls.play();
        }
        public static void SunetExplozieControlPlay()
        {
            explozie.controls.play();
        }
        public static void SunetJocTerminatControlPlay()
        {
            game_over.controls.play();
        }
    }
}
