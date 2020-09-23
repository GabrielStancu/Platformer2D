namespace Platformer_2D
{
    partial class MeniuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btJocNou = new System.Windows.Forms.Button();
            this.btInstructiuni = new System.Windows.Forms.Button();
            this.btIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(238, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platformer 2D";
            // 
            // btJocNou
            // 
            this.btJocNou.BackColor = System.Drawing.Color.Green;
            this.btJocNou.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btJocNou.Location = new System.Drawing.Point(427, 232);
            this.btJocNou.Name = "btJocNou";
            this.btJocNou.Size = new System.Drawing.Size(265, 60);
            this.btJocNou.TabIndex = 1;
            this.btJocNou.Text = "Joc Nou";
            this.btJocNou.UseVisualStyleBackColor = false;
            this.btJocNou.Click += new System.EventHandler(this.btJocNou_Click);
            // 
            // btInstructiuni
            // 
            this.btInstructiuni.BackColor = System.Drawing.Color.Green;
            this.btInstructiuni.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btInstructiuni.Location = new System.Drawing.Point(427, 313);
            this.btInstructiuni.Name = "btInstructiuni";
            this.btInstructiuni.Size = new System.Drawing.Size(265, 60);
            this.btInstructiuni.TabIndex = 2;
            this.btInstructiuni.Text = "Instructiuni";
            this.btInstructiuni.UseVisualStyleBackColor = false;
            this.btInstructiuni.Click += new System.EventHandler(this.btInstructiuni_Click);
            // 
            // btIesire
            // 
            this.btIesire.BackColor = System.Drawing.Color.Green;
            this.btIesire.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btIesire.Location = new System.Drawing.Point(427, 394);
            this.btIesire.Name = "btIesire";
            this.btIesire.Size = new System.Drawing.Size(265, 60);
            this.btIesire.TabIndex = 3;
            this.btIesire.Text = "Iesire Joc";
            this.btIesire.UseVisualStyleBackColor = false;
            this.btIesire.Click += new System.EventHandler(this.btIesire_Click);
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Platformer_2D.Properties.Resources.fundal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 524);
            this.ControlBox = false;
            this.Controls.Add(this.btIesire);
            this.Controls.Add(this.btInstructiuni);
            this.Controls.Add(this.btJocNou);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MeniuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btJocNou;
        private System.Windows.Forms.Button btInstructiuni;
        private System.Windows.Forms.Button btIesire;
    }
}