namespace Logik
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnNewgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBox.Location = new System.Drawing.Point(12, 12);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(304, 360);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_Paint);
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseClick);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.Yellow;
            this.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvaluate.Location = new System.Drawing.Point(12, 378);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(135, 23);
            this.btnEvaluate.TabIndex = 1;
            this.btnEvaluate.Text = "Vyhodnotit";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            // 
            // btnNewgame
            // 
            this.btnNewgame.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewgame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewgame.Location = new System.Drawing.Point(181, 378);
            this.btnNewgame.Name = "btnNewgame";
            this.btnNewgame.Size = new System.Drawing.Size(135, 23);
            this.btnNewgame.TabIndex = 2;
            this.btnNewgame.Text = "Nová hra";
            this.btnNewgame.UseVisualStyleBackColor = false;
            this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(328, 413);
            this.Controls.Add(this.btnNewgame);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnNewgame;
    }
}

