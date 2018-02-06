using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    /// <summary>
    /// Creates a window with a list of the games.
    /// It allows you to search for the name of the player who won, how many times he won and with which players.
    /// =========================================================================================================
    /// Tworzy okno z listą wygranych gier zapisanych aktualnie w pliku.
    /// Umożliwia wyszukiwanie imienia gracza który wygrał, ile razy wygrał i z jakimi graczami.
    /// </summary>
    public partial class Results : Form
    {
        string lookingFor = "";
        string lpp = "";
        string winner = "";
        string looser = "";

        bool one = false;
        bool two = false;

        string[] readText;
        List<Label> loosersList = new List<Label>();

        int counter = 0;

        public Results()
        {
            InitializeComponent();
            MakeList();
        }

        /// <summary>
        /// Creates a list with all wins played and saved in the file.
        /// Tworzy listę z wszystkimi wygranymi rozegranymi i zapisanymi w pliku.
        /// </summary>
        private void MakeList()
        {
            try { readText = File.ReadAllLines(Settings.FileName); }
            catch (UnauthorizedAccessException) { }
            catch (FileNotFoundException)
            {
                StreamWriter sw = new StreamWriter(Settings.FileName);              //It's required for correct writing the scores.
                sw.WriteLine();                                                     //The first line must be free.
                sw.Close();                                                         //Potrzebne do poprawnego zapisywania wyników.
                readText = File.ReadAllLines(Settings.FileName);                    //Pierwsza linia musi być wolna.
            }

            for (int i = 1; i < readText.Length; i++)
            {
                if (i % 2 == 0)
                {
                    this.looser = this.readText[i];
                    this.one = true;
                }
                if (i % 2 != 0)
                {
                    this.winner = this.readText[i];
                    this.two = true;
                }
                if (this.one && this.two)
                {
                    this.counter++;
                    this.lpp = counter + "";
                    ListViewItem lvi = new ListViewItem(this.lpp);
                    lvi.SubItems.Add(winner);
                    lvi.SubItems.Add(looser);
                    this.listView1.Items.Add(lvi);
                    this.one = false;
                    this.two = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Creates a list of players who lost to the searched player.
        /// Tworzy listę graczy którzy przegrali z graczem szukanym. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLookingForWinner_Click(object sender, EventArgs e)
        {
            int numberOfWins = 0;
            lviLoosers.Items.Clear();
            lookingFor = this.tBLookingForWiner.Text;

            foreach (Label l in loosersList) { l.Visible = false; }
            loosersList.Clear();

            for (int i = 0; i < readText.Length; i++)
            {
                if (readText[i] == lookingFor && i % 2 != 0)
                {
                    this.counter++;
                    this.lpp = counter + "";
                    ListViewItem lvi = new ListViewItem(readText[i + 1]);
                    this.lviLoosers.Items.Add(lvi);
                    numberOfWins++;  
                }
            }

            this.lInfoAboutWinner.Visible = true;
            //We have difference in speaking in Polish in singular and plural, we need change our last letter. | Różnica w ostatniej literce zdania.
            if (numberOfWins == 1)
                this.lInfoAboutWinner.Text = "Gracz o imieniu " + this.lookingFor + " wygrał " + numberOfWins + " raz.\n";  //"The player named" + this.lookingFor + "won" + numberOfWins + "time.\n"
            else
                this.lInfoAboutWinner.Text = "Gracz o imieniu " + this.lookingFor + " wygrał " + numberOfWins + " razy.\n"; //"The player named" + this.lookingFor + "won" + numberOfWins + "times.\n"

            this.labelLoosersList.Text = "Lista przegranych graczy z graczem " + this.lookingFor;                           //"List of players who was beaten by the player."
            foreach (Label l in loosersList) { this.Controls.Add(l); }
        }
    }
}

