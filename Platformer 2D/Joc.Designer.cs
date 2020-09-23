namespace Platformer_2D
{
    partial class Joc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBen = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer_aparitie = new System.Windows.Forms.Timer(this.components);
            this.timer_deplasare_stanga_dreapta = new System.Windows.Forms.Timer(this.components);
            this.timer_cadere_salt = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbScor = new System.Windows.Forms.Label();
            this.pnPierdut = new System.Windows.Forms.Panel();
            this.btMeniu = new System.Windows.Forms.Button();
            this.btReplay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_schimbare = new System.Windows.Forms.Timer(this.components);
            this.timerLimitareSaritura = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnPierdut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Platformer_2D.Properties.Resources.platforma_iarba1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(856, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 97);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbBen
            // 
            this.pbBen.BackColor = System.Drawing.Color.Transparent;
            this.pbBen.BackgroundImage = global::Platformer_2D.Properties.Resources.deplasare1;
            this.pbBen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBen.Location = new System.Drawing.Point(123, 197);
            this.pbBen.Name = "pbBen";
            this.pbBen.Size = new System.Drawing.Size(105, 133);
            this.pbBen.TabIndex = 3;
            this.pbBen.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Platformer_2D.Properties.Resources.platforma_iarba1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(123, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(496, 97);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // timer_aparitie
            // 
            this.timer_aparitie.Interval = 1750;
            this.timer_aparitie.Tick += new System.EventHandler(this.timer_aparitie_Tick);
            // 
            // timer_deplasare_stanga_dreapta
            // 
            this.timer_deplasare_stanga_dreapta.Interval = 10;
            this.timer_deplasare_stanga_dreapta.Tick += new System.EventHandler(this.timer_deplasare_stanga_dreapta_Tick);
            // 
            // timer_cadere_salt
            // 
            this.timer_cadere_salt.Interval = 10;
            this.timer_cadere_salt.Tick += new System.EventHandler(this.timer_cadere_salt_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1015, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scor:";
            // 
            // lbScor
            // 
            this.lbScor.AutoSize = true;
            this.lbScor.BackColor = System.Drawing.Color.Transparent;
            this.lbScor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScor.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbScor.Location = new System.Drawing.Point(1085, 9);
            this.lbScor.Name = "lbScor";
            this.lbScor.Size = new System.Drawing.Size(31, 37);
            this.lbScor.TabIndex = 7;
            this.lbScor.Text = "0";
            // 
            // pnPierdut
            // 
            this.pnPierdut.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnPierdut.BackgroundImage = global::Platformer_2D.Properties.Resources.panou;
            this.pnPierdut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPierdut.Controls.Add(this.btMeniu);
            this.pnPierdut.Controls.Add(this.btReplay);
            this.pnPierdut.Controls.Add(this.label3);
            this.pnPierdut.Controls.Add(this.label2);
            this.pnPierdut.Location = new System.Drawing.Point(415, 155);
            this.pnPierdut.Name = "pnPierdut";
            this.pnPierdut.Size = new System.Drawing.Size(400, 250);
            this.pnPierdut.TabIndex = 8;
            this.pnPierdut.Visible = false;
            // 
            // btMeniu
            // 
            this.btMeniu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btMeniu.Location = new System.Drawing.Point(216, 187);
            this.btMeniu.Name = "btMeniu";
            this.btMeniu.Size = new System.Drawing.Size(128, 33);
            this.btMeniu.TabIndex = 3;
            this.btMeniu.Text = "Meniul principal";
            this.btMeniu.UseVisualStyleBackColor = true;
            this.btMeniu.Click += new System.EventHandler(this.btMeniu_Click);
            // 
            // btReplay
            // 
            this.btReplay.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btReplay.Location = new System.Drawing.Point(64, 187);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(128, 33);
            this.btReplay.TabIndex = 2;
            this.btReplay.Text = "Joaca din nou";
            this.btReplay.UseVisualStyleBackColor = true;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 76);
            this.label3.TabIndex = 1;
            this.label3.Text = "Scorul maxim\r\neste";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ai pierdut\r\nScorul tau este ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_schimbare
            // 
            this.timer_schimbare.Interval = 250;
            this.timer_schimbare.Tick += new System.EventHandler(this.timer_schimbare_Tick);
            // 
            // timerLimitareSaritura
            // 
            this.timerLimitareSaritura.Interval = 10;
            this.timerLimitareSaritura.Tick += new System.EventHandler(this.timerLimitareSaritura_Tick);
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer_2D.Properties.Resources.fundal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pnPierdut);
            this.Controls.Add(this.lbScor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbBen);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Joc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Joc_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Joc_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnPierdut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer_aparitie;
        private System.Windows.Forms.Timer timer_deplasare_stanga_dreapta;
        private System.Windows.Forms.Timer timer_cadere_salt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScor;
        private System.Windows.Forms.Panel pnPierdut;
        private System.Windows.Forms.Button btReplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_schimbare;
        private System.Windows.Forms.Button btMeniu;
        private System.Windows.Forms.Timer timerLimitareSaritura;
    }
}

