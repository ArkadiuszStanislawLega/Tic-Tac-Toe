using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickTackToe.Properties;

namespace TickTackToe
{
     public class Area :IComparable
    {
        public Button area { get; private set; }
        public int ID { get; private set; }

        public Area(int id, int x, int y)
        {
            this.ID = id;
            area = new Button();
            this.area.AutoSize = true;
            this.area.BackColor = System.Drawing.Color.Transparent;
            this.area.ForeColor = System.Drawing.Color.Black;
            this.area.UseVisualStyleBackColor = true;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.area.Location = new System.Drawing.Point(x, y);
            this.area.Name = "label";
            this.area.MaximumSize = new System.Drawing.Size(37, 37);
            this.area.MinimumSize = new System.Drawing.Size(37, 37);
            this.area.Size = new System.Drawing.Size(37, 37);
            this.area.TabIndex = 0;
            this.area.Text = " ";
            this.area.Visible = true;
            this.area.FlatStyle = FlatStyle.System;
            this.area.TextAlign = ContentAlignment.MiddleCenter;
            this.area.Click += new EventHandler(Clicker);
        }

        private void Clicker(object sender, EventArgs e)
        {
            if (Settings.UnmuteSound) Sound.Klick();
       
            Settings.ListWithId.Add(this.ID);

            this.area.Enabled = false;
            if (Settings.Player1)
            {
                this.area.Text = "X";
                Settings.Player1 = false;
                Settings.Player2 = true;
                Settings.LookingForWin("X");
            }
            else
            {
                this.area.Text = "O";
                Settings.Player2 = false;
                Settings.Player1 = true;
                Settings.LookingForWin("O");
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 0;
            Area otherArea = obj as Area;
            if (otherArea.area.Text == this.area.Text)  return 1; 
            else return 0;
        }
    }
}
