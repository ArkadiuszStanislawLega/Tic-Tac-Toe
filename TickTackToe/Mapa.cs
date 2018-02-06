using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickTackToe.Properties;

namespace TickTackToe
{
    /// <summary>
    /// Creates a game map.Enables gameplay.
    /// ==================================================
    /// Tworzy mapę z grą. Umożliwia prowadzenie rozgrywki.
    /// </summary>
    public partial class Mapa : Form
    {
        Graphics g;
        Label lNameOfPlayer1 = new Label();     
        Label lNameOfPlayer2 = new Label();

        public Mapa()
        {
            InitializeComponent();
            MakeSpaceForPlay();

            if (Settings.SizeOfNamePlayer2 > Settings.SizeOfNamePlayer1)
                this.Size = new System.Drawing.Size(Settings.L[0, Settings.NumberOfColumns - 1].area.Location.X + 55 + (int)Settings.SizeOfNamePlayer2, 
                    Settings.L[Settings.NumberOfColumns - 1, 0].area.Location.Y + 78);
            else
                this.Size = new System.Drawing.Size(Settings.L[0, Settings.NumberOfColumns - 1].area.Location.X + 55 + (int)Settings.SizeOfNamePlayer1, 
                    Settings.L[Settings.NumberOfColumns - 1, 0].area.Location.Y + 78);

            if (Settings.meesegeBoxSended) Settings.meesegeBoxSended = false;
        }

        /// <summary>
        /// Creates Buttons for game.
        /// Tworzy Buttony do gry.
        /// </summary>
        private void MakeSpaceForPlay()
        {
            int firstX = 0;
            int firstY = 0;
            int firstSize1 = Settings.FirstSize;
            for (int i = 0; i < Settings.NumberOfColumns; i++)
            {
                for (int z = 0; z < Settings.NumberOfColumns; z++)
                {
                    Settings.L[i, z] = new Area(Settings.AreaID, firstX + Settings.Size + Settings.SizeBetweenThem, firstY); Settings.AreaID++;
                    if (z == 0)
                    {
                        Settings.L[i, z].area.Location = new Point(0, firstY);
                    }
                    else { Settings.Size += Settings.FirstSize; }

                    this.Controls.Add(Settings.L[i, z].area);
                }
                Settings.Size = Settings.FirstSize;
                firstY += Settings.FirstSize + Settings.SizeBetweenThem;
            }
        }

        /// <summary>
        /// Everything for draw the lines, between areas for play game.
        /// Wszystko co potrzebne do narysowania lini, po między polami do gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Settings.NumberOfColumns - 1; i++)
            {
                for (int z = 0; z < Settings.NumberOfColumns - 1; z++)
                {
                    DrawVerticalLine(e, Settings.L[0, z].area, Settings.L[2, z].area);
                }
                DrawHorizontalLine(e, Settings.L[i, 0].area, Settings.L[i, 1].area);
            }
        }

        /// <summary>
        /// Draw the lines.
        /// Rysuje pionowe kreski.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="first">Pierwsze pole które będzie </param>
        /// <param name="last"></param>
        private void DrawVerticalLine(PaintEventArgs e, Button first, Button last)
        {
            g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Black, 2), first.Location.X + first.Font.Height + 1, 5, last.Location.X + last.Font.Height + 1, this.Size.Height - 45);
            g.DrawString("" + first.Font.Height, new Font("Consolas", 10), Brushes.Black, 0, 0);
        }

        /// <summary>
        /// Draws horizontal lines and strings indicating which person should actually make the move.
        /// Rysuje poziome kreski oraz napisy wskazujące który gracz akutalnie wykonuje ruch.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="first">First free area for play. | Pierwsze puste pole do gry.</param>
        /// <param name="last">Last free area for play. |Ostatnie puste pole do gry.</param>
        private void DrawHorizontalLine(PaintEventArgs e, Button first, Button last)
        {
            g = e.Graphics;
            if ((int)Settings.SizeOfNamePlayer2 > (int)Settings.SizeOfNamePlayer1)
                g.DrawLine(new Pen(Brushes.Black, 2), 5, first.Location.Y + first.Font.Height + 2, this.Size.Width - 20 - (int)Settings.SizeOfNamePlayer2, 
                    last.Location.Y + last.Font.Height + 2);
            else
                g.DrawLine(new Pen(Brushes.Black, 2), 5, first.Location.Y + first.Font.Height + 2, this.Size.Width - 20 - (int)Settings.SizeOfNamePlayer1, 
                    last.Location.Y + last.Font.Height + 2);

            this.lNameOfPlayer1.AutoSize = true;
            this.lNameOfPlayer1.Name = "lNameOfPlayer1";
            this.lNameOfPlayer1.Size = new System.Drawing.Size(87, 13);
            this.lNameOfPlayer1.TabIndex = 8;
            this.lNameOfPlayer1.Location = new Point (this.Size.Width - 20 - (int)Settings.SizeOfNamePlayer2 + 5, 10);
            this.Controls.Add(lNameOfPlayer1);

            this.lNameOfPlayer2.AutoSize = true;
            this.lNameOfPlayer2.Name = "lNameOfPlayer2";
            this.lNameOfPlayer2.Size = new System.Drawing.Size(87, 13);
            this.lNameOfPlayer2.TabIndex = 8;
            this.lNameOfPlayer2.Location = new Point(this.Size.Width - 20 - (int)Settings.SizeOfNamePlayer2 + 5, 25);
            this.Controls.Add(lNameOfPlayer2);

            if (Settings.Player1)
            {
                this.lNameOfPlayer1.Text = "X " +Settings.Player1Name;
                this.lNameOfPlayer2.Text = Settings.Player2Name;
                this.lNameOfPlayer1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                this.lNameOfPlayer2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            }
            else
            {
                this.lNameOfPlayer1.Text = Settings.Player1Name;
                this.lNameOfPlayer2.Text = "O " + Settings.Player2Name;
                this.lNameOfPlayer1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                this.lNameOfPlayer2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));    
            }
        }

        /// <summary>
        /// Undo button for remove last move.
        /// Klawisz cofnięcia ostatniego ruchu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (Settings.UnmuteSound) Sound.Back();
           
                foreach (Area a in Settings.L)
                {
                    if (a.ID == Settings.ListWithId[Settings.ListWithId.Count - 1])
                    {
                        a.area.Text = " ";
                        a.area.Enabled = true;
                    }
                }
                if (Settings.Player1) { Settings.Player1 = false; Settings.Player2 = true; }
                else { Settings.Player2 = false; Settings.Player1 = true; }
            }
        }
    }
}
