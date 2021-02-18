namespace GameInavsion
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new System.Windows.Forms.PictureBox();
            this.Miscare_stanga = new System.Windows.Forms.Timer(this.components);
            this.Miscare_dreapta = new System.Windows.Forms.Timer(this.components);
            this.Miscare_sus = new System.Windows.Forms.Timer(this.components);
            this.Miscare_jos = new System.Windows.Forms.Timer(this.components);
            this.Miscare_munitie = new System.Windows.Forms.Timer(this.components);
            this.Miscare_inamici = new System.Windows.Forms.Timer(this.components);
            this.Miscare_munitie_inamici = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Replay_button = new System.Windows.Forms.Button();
            this.Iesire_button = new System.Windows.Forms.Button();
            this.Scorlbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Miscare_fundal_timer = new System.Windows.Forms.Timer(this.components);
            this.score_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(348, 471);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Miscare_stanga
            // 
            this.Miscare_stanga.Interval = 5;
            this.Miscare_stanga.Tick += new System.EventHandler(this.Miscare_stanga_Tick);
            // 
            // Miscare_dreapta
            // 
            this.Miscare_dreapta.Interval = 5;
            this.Miscare_dreapta.Tick += new System.EventHandler(this.Miscare_dreapta_Tick);
            // 
            // Miscare_sus
            // 
            this.Miscare_sus.Interval = 5;
            this.Miscare_sus.Tick += new System.EventHandler(this.Miscare_sus_Tick);
            // 
            // Miscare_jos
            // 
            this.Miscare_jos.Interval = 5;
            this.Miscare_jos.Tick += new System.EventHandler(this.Miscare_jos_Tick);
            // 
            // Miscare_munitie
            // 
            this.Miscare_munitie.Enabled = true;
            this.Miscare_munitie.Interval = 20;
            this.Miscare_munitie.Tick += new System.EventHandler(this.Miscare_munitie_Tick);
            // 
            // Miscare_inamici
            // 
            this.Miscare_inamici.Enabled = true;
            this.Miscare_inamici.Tick += new System.EventHandler(this.Miscare_inamici_Tick);
            // 
            // Miscare_munitie_inamici
            // 
            this.Miscare_munitie_inamici.Enabled = true;
            this.Miscare_munitie_inamici.Interval = 20;
            this.Miscare_munitie_inamici.Tick += new System.EventHandler(this.Miscare_munitie_inamici_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 141);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Replay_button
            // 
            this.Replay_button.BackColor = System.Drawing.Color.Black;
            this.Replay_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Replay_button.Font = new System.Drawing.Font("Unispace", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_button.ForeColor = System.Drawing.Color.Red;
            this.Replay_button.Location = new System.Drawing.Point(217, 248);
            this.Replay_button.Name = "Replay_button";
            this.Replay_button.Size = new System.Drawing.Size(324, 60);
            this.Replay_button.TabIndex = 2;
            this.Replay_button.Text = "REPLAY";
            this.Replay_button.UseVisualStyleBackColor = false;
            this.Replay_button.Visible = false;
            this.Replay_button.Click += new System.EventHandler(this.Replay_button_Click);
            // 
            // Iesire_button
            // 
            this.Iesire_button.BackColor = System.Drawing.Color.Black;
            this.Iesire_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Iesire_button.Font = new System.Drawing.Font("Unispace", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iesire_button.ForeColor = System.Drawing.Color.Red;
            this.Iesire_button.Location = new System.Drawing.Point(217, 344);
            this.Iesire_button.Name = "Iesire_button";
            this.Iesire_button.Size = new System.Drawing.Size(324, 59);
            this.Iesire_button.TabIndex = 3;
            this.Iesire_button.Text = "IESIRE";
            this.Iesire_button.UseVisualStyleBackColor = false;
            this.Iesire_button.Visible = false;
            this.Iesire_button.Click += new System.EventHandler(this.Iesire_button_Click);
            // 
            // Scorlbl
            // 
            this.Scorlbl.BackColor = System.Drawing.Color.Transparent;
            this.Scorlbl.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorlbl.ForeColor = System.Drawing.Color.Red;
            this.Scorlbl.Location = new System.Drawing.Point(53, 7);
            this.Scorlbl.Name = "Scorlbl";
            this.Scorlbl.Size = new System.Drawing.Size(34, 19);
            this.Scorlbl.TabIndex = 4;
            this.Scorlbl.Text = "00";
            // 
            // levellbl
            // 
            this.levellbl.BackColor = System.Drawing.Color.Transparent;
            this.levellbl.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Red;
            this.levellbl.Location = new System.Drawing.Point(730, 9);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(43, 42);
            this.levellbl.TabIndex = 5;
            this.levellbl.Text = "01";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "SCOR:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(665, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "LEVEL:";
            // 
            // Miscare_fundal_timer
            // 
            this.Miscare_fundal_timer.Enabled = true;
            this.Miscare_fundal_timer.Interval = 10;
            this.Miscare_fundal_timer.Tick += new System.EventHandler(this.Miscare_fundal_timer_Tick);
            // 
            // score_button
            // 
            this.score_button.BackColor = System.Drawing.Color.Black;
            this.score_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.score_button.Font = new System.Drawing.Font("Unispace", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_button.ForeColor = System.Drawing.Color.Red;
            this.score_button.Location = new System.Drawing.Point(91, 3);
            this.score_button.Name = "score_button";
            this.score_button.Size = new System.Drawing.Size(75, 23);
            this.score_button.TabIndex = 8;
            this.score_button.Text = "Scoruri";
            this.score_button.UseVisualStyleBackColor = false;
            this.score_button.Visible = false;
            this.score_button.Click += new System.EventHandler(this.score_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 605);
            this.Controls.Add(this.score_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.Scorlbl);
            this.Controls.Add(this.Iesire_button);
            this.Controls.Add(this.Replay_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(794, 605);
            this.MinimumSize = new System.Drawing.Size(794, 605);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceInvader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Player;
        public System.Windows.Forms.Timer Miscare_stanga;
        public System.Windows.Forms.Timer Miscare_dreapta;
        public System.Windows.Forms.Timer Miscare_sus;
        public System.Windows.Forms.Timer Miscare_jos;
        public System.Windows.Forms.Timer Miscare_munitie;
        public System.Windows.Forms.Timer Miscare_inamici;
        public System.Windows.Forms.Timer Miscare_munitie_inamici;
        public  System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Replay_button;
        public System.Windows.Forms.Button Iesire_button;
        public System.Windows.Forms.Label Scorlbl;
        public System.Windows.Forms.Label levellbl;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer Miscare_fundal_timer;
        public System.Windows.Forms.Button score_button;
    }
}

