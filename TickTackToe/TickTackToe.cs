using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class TickTackToe : Form
    {
        /// <summary>
        /// Creates the first window, menu.
        /// Allows you to change the names of players, choose the size of the map, change the conditions of victory,
        /// if you want to hear the sounds of the game and go to the window with the results of the game.
        /// ========================================================================================================
        /// Tworzy pierwsze okno, menu.
        /// Umożliwia zmianę imion graczy, wybór rozmiaru mapy, zmianę warunków zwycięstwa,
        /// czy mają być słyszalne dźwięki gry oraz przejście do okna z wynikami gry.
        /// </summary>
        public TickTackToe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Confirms the settings of the current game.
        /// Zatwierdza dokonane ustawienia aktualnej gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.nUdNeedForWin.Value <= this.nUaDSizeOfMap.Value && this.nUdNeedForWin.Value >= 3)
            {
                Settings.Player1Name = this.tBPlayer1.Text;
                Settings.Player2Name = this.tBPlayer2.Text;
                Settings.SizeOfNamePlayer1 = (this.tBPlayer1.Text.LongCount() + 5)*8;
                Settings.SizeOfNamePlayer2 = (this.tBPlayer2.Text.LongCount() + 5)*8;
                Settings.NumberOfColumns = (int)this.nUaDSizeOfMap.Value;
                Settings.NeedToWin = (int)this.nUdNeedForWin.Value;
                Settings.GenerateTable();
                Mapa m = new Mapa();
                m.Show();
            }
            else
            { MessageBox.Show("Wartość wymagana do zwycięstwa musi być mniejsza lub równa wielkości mapy."); }//The value required for victory must be less or equal than the size of the map.
        }

        /// <summary>
        /// Showing window whith results.
        /// Pokazuje okno z listą wygranych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bResults_Click(object sender, EventArgs e)
        {
            Results r = new Results();
            r.Show();
        }

        /// <summary>
        /// Choosing the audibility of sounds from the game.
        /// Wybór słyszalności dźwieków z gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSound.Checked) Settings.UnmuteSound = true;
            else Settings.UnmuteSound = false;
        }
    }
}
