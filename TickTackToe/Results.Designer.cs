namespace TickTackToe
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.winners = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.losers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Winner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tBLookingForWiner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bLookingForWinner = new System.Windows.Forms.Button();
            this.lInfoAboutWinner = new System.Windows.Forms.Label();
            this.lviLoosers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLoosersList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lp,
            this.Winner,
            this.Loser});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(249, 360);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lp
            // 
            this.lp.Text = "lp";
            // 
            // Winner
            // 
            this.Winner.Text = "Wygrany";
            // 
            // Loser
            // 
            this.Loser.Text = "Przegrany";
            // 
            // tBLookingForWiner
            // 
            this.tBLookingForWiner.Location = new System.Drawing.Point(384, 34);
            this.tBLookingForWiner.Name = "tBLookingForWiner";
            this.tBLookingForWiner.Size = new System.Drawing.Size(190, 20);
            this.tBLookingForWiner.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szukaj zwycięzcę:";
            // 
            // bLookingForWinner
            // 
            this.bLookingForWinner.Location = new System.Drawing.Point(499, 60);
            this.bLookingForWinner.Name = "bLookingForWinner";
            this.bLookingForWinner.Size = new System.Drawing.Size(75, 23);
            this.bLookingForWinner.TabIndex = 5;
            this.bLookingForWinner.Text = "Szukaj";
            this.bLookingForWinner.UseVisualStyleBackColor = true;
            this.bLookingForWinner.Click += new System.EventHandler(this.bLookingForWinner_Click);
            // 
            // lInfoAboutWinner
            // 
            this.lInfoAboutWinner.AutoSize = true;
            this.lInfoAboutWinner.Location = new System.Drawing.Point(287, 105);
            this.lInfoAboutWinner.Name = "lInfoAboutWinner";
            this.lInfoAboutWinner.Size = new System.Drawing.Size(35, 13);
            this.lInfoAboutWinner.TabIndex = 6;
            this.lInfoAboutWinner.Text = "label2";
            this.lInfoAboutWinner.Visible = false;
            // 
            // lviLoosers
            // 
            this.lviLoosers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lviLoosers.Location = new System.Drawing.Point(287, 144);
            this.lviLoosers.Name = "lviLoosers";
            this.lviLoosers.Size = new System.Drawing.Size(287, 228);
            this.lviLoosers.TabIndex = 7;
            this.lviLoosers.UseCompatibleStateImageBehavior = false;
            this.lviLoosers.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Przegrani";
            // 
            // labelLoosersList
            // 
            this.labelLoosersList.AutoSize = true;
            this.labelLoosersList.Location = new System.Drawing.Point(287, 128);
            this.labelLoosersList.Name = "labelLoosersList";
            this.labelLoosersList.Size = new System.Drawing.Size(87, 13);
            this.labelLoosersList.TabIndex = 8;
            this.labelLoosersList.Text = "List przegranych:";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.labelLoosersList);
            this.Controls.Add(this.lviLoosers);
            this.Controls.Add(this.lInfoAboutWinner);
            this.Controls.Add(this.bLookingForWinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBLookingForWiner);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Results";
            this.Text = "Lista zwycięstw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ColumnHeader winners;
        private System.Windows.Forms.ColumnHeader losers;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lp;
        private System.Windows.Forms.ColumnHeader Winner;
        private System.Windows.Forms.ColumnHeader Loser;
        private System.Windows.Forms.TextBox tBLookingForWiner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLookingForWinner;
        private System.Windows.Forms.Label lInfoAboutWinner;
        private System.Windows.Forms.ListView lviLoosers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label labelLoosersList;
    }
}