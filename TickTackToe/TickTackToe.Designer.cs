namespace TickTackToe
{
    partial class TickTackToe
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.nUaDSizeOfMap = new System.Windows.Forms.NumericUpDown();
            this.nUdNeedForWin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPlayer1 = new System.Windows.Forms.TextBox();
            this.tBPlayer2 = new System.Windows.Forms.TextBox();
            this.bResults = new System.Windows.Forms.Button();
            this.cbSound = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUaDSizeOfMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdNeedForWin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kółko i krzyżyk";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(198, 301);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "GO!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // nUaDSizeOfMap
            // 
            this.nUaDSizeOfMap.Location = new System.Drawing.Point(185, 202);
            this.nUaDSizeOfMap.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUaDSizeOfMap.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUaDSizeOfMap.Name = "nUaDSizeOfMap";
            this.nUaDSizeOfMap.Size = new System.Drawing.Size(120, 20);
            this.nUaDSizeOfMap.TabIndex = 2;
            this.nUaDSizeOfMap.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nUdNeedForWin
            // 
            this.nUdNeedForWin.Location = new System.Drawing.Point(185, 228);
            this.nUdNeedForWin.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUdNeedForWin.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUdNeedForWin.Name = "nUdNeedForWin";
            this.nUdNeedForWin.Size = new System.Drawing.Size(120, 20);
            this.nUdNeedForWin.TabIndex = 3;
            this.nUdNeedForWin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wielkość mapy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość potrzebna do zwycięstwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imię gracza pierwszego";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Imię gracza drugiego";
            // 
            // tBPlayer1
            // 
            this.tBPlayer1.Location = new System.Drawing.Point(185, 132);
            this.tBPlayer1.Name = "tBPlayer1";
            this.tBPlayer1.Size = new System.Drawing.Size(120, 20);
            this.tBPlayer1.TabIndex = 8;
            this.tBPlayer1.Text = "Gracz1";
            // 
            // tBPlayer2
            // 
            this.tBPlayer2.Location = new System.Drawing.Point(185, 158);
            this.tBPlayer2.Name = "tBPlayer2";
            this.tBPlayer2.Size = new System.Drawing.Size(120, 20);
            this.tBPlayer2.TabIndex = 9;
            this.tBPlayer2.Text = "Gracz2";
            // 
            // bResults
            // 
            this.bResults.Location = new System.Drawing.Point(96, 301);
            this.bResults.Name = "bResults";
            this.bResults.Size = new System.Drawing.Size(75, 23);
            this.bResults.TabIndex = 10;
            this.bResults.Text = "Wyniki";
            this.bResults.UseVisualStyleBackColor = true;
            this.bResults.Click += new System.EventHandler(this.bResults_Click);
            // 
            // cbSound
            // 
            this.cbSound.AutoSize = true;
            this.cbSound.Checked = true;
            this.cbSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSound.Location = new System.Drawing.Point(309, 390);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(61, 17);
            this.cbSound.TabIndex = 11;
            this.cbSound.Text = "Dźwięk";
            this.cbSound.UseVisualStyleBackColor = true;
            this.cbSound.CheckedChanged += new System.EventHandler(this.cbSound_CheckedChanged);
            // 
            // TickTackToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 419);
            this.Controls.Add(this.cbSound);
            this.Controls.Add(this.bResults);
            this.Controls.Add(this.tBPlayer2);
            this.Controls.Add(this.tBPlayer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUdNeedForWin);
            this.Controls.Add(this.nUaDSizeOfMap);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label1);
            this.Name = "TickTackToe";
            this.Text = "Kółko i krzyżyk";
            ((System.ComponentModel.ISupportInitialize)(this.nUaDSizeOfMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUdNeedForWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.NumericUpDown nUaDSizeOfMap;
        private System.Windows.Forms.NumericUpDown nUdNeedForWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBPlayer1;
        private System.Windows.Forms.TextBox tBPlayer2;
        private System.Windows.Forms.Button bResults;
        private System.Windows.Forms.CheckBox cbSound;
    }
}

