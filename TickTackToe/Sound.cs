using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Properties;

namespace TickTackToe
{
    /// <summary>
    /// It's responsible for all sounds in the game.
    /// Odpowiada za wszsytkie dźwięki w grze.
    /// </summary>
    public static class Sound
    {
        /// <summary>
        /// When somone win.
        /// Kiedy ktoś wygra.
        /// </summary>
        public static void Winner()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.win);
            player.Load();
            player.Play();
        }

        /// <summary>
        /// When someone click on free area.
        /// Kiedy ktoś kliknie na puste pole.
        /// </summary>
        public static void Klick()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.klick);
            player.Load();
            player.Play();
        }

        /// <summary>
        /// When someone click backspace.
        /// Kiedy ktoś kliknie bacspace.
        /// </summary>
        public static void Back()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.back);
            player.Load();
            player.Play();
        }
    }
}
