namespace PinponGameSample
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.Playgroun = new System.Windows.Forms.Panel();
            this.Gameover_lbl = new System.Windows.Forms.Label();
            this.Points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.Ball_lbl = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Playgroun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_lbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Playgroun
            // 
            this.Playgroun.Controls.Add(this.Gameover_lbl);
            this.Playgroun.Controls.Add(this.Points_lbl);
            this.Playgroun.Controls.Add(this.score_lbl);
            this.Playgroun.Controls.Add(this.Ball_lbl);
            this.Playgroun.Controls.Add(this.Racket);
            this.Playgroun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playgroun.Location = new System.Drawing.Point(0, 0);
            this.Playgroun.Name = "Playgroun";
            this.Playgroun.Size = new System.Drawing.Size(800, 450);
            this.Playgroun.TabIndex = 0;
            // 
            // Gameover_lbl
            // 
            this.Gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gameover_lbl.Location = new System.Drawing.Point(197, 108);
            this.Gameover_lbl.Name = "Gameover_lbl";
            this.Gameover_lbl.Size = new System.Drawing.Size(420, 155);
            this.Gameover_lbl.TabIndex = 4;
            this.Gameover_lbl.Text = "          Game Over!\r\nPress F1 for restart game\r\n           Esc for exit\r\n";
            // 
            // Points_lbl
            // 
            this.Points_lbl.AutoSize = true;
            this.Points_lbl.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points_lbl.Location = new System.Drawing.Point(175, 9);
            this.Points_lbl.Name = "Points_lbl";
            this.Points_lbl.Size = new System.Drawing.Size(66, 74);
            this.Points_lbl.TabIndex = 3;
            this.Points_lbl.Text = "0";
            this.Points_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(3, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(193, 74);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score :";
            // 
            // Ball_lbl
            // 
            this.Ball_lbl.BackColor = System.Drawing.Color.Red;
            this.Ball_lbl.Location = new System.Drawing.Point(384, 266);
            this.Ball_lbl.Name = "Ball_lbl";
            this.Ball_lbl.Size = new System.Drawing.Size(30, 30);
            this.Ball_lbl.TabIndex = 1;
            this.Ball_lbl.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Black;
            this.Racket.Location = new System.Drawing.Point(299, 418);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(200, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playgroun);
            this.Name = "GameForm";
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.Playgroun.ResumeLayout(false);
            this.Playgroun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_lbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Playgroun;
        private System.Windows.Forms.Label Gameover_lbl;
        private System.Windows.Forms.Label Points_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox Ball_lbl;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer1;
    }
}

