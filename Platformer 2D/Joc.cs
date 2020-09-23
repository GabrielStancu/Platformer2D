using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Platformer_2D
{
    public partial class Joc : Form
    {
        int HighScore = 0;
        public Joc(int scor_maxim)
        {
            InitializeComponent();
            HighScore = scor_maxim;
            this.Focus();
        }

        bool left = false;
        bool right = false;
        bool up = false;
        int viteza = 13;

        bool cadere = false;

        int indice_imagine = 1;

        private void Joc_Load(object sender, EventArgs e)
        {
            timer_aparitie.Start();
            timer_deplasare_stanga_dreapta.Start();
            timer_cadere_salt.Start();
            timer_schimbare.Start();
            timerLimitareSaritura.Start();

            pbBen.BringToFront();
        }

        private void Joc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = true;
            else if (e.KeyCode == Keys.Right) right = true;
            else if (e.KeyCode == Keys.Up) if (cadere == false) { up = true; cadere = true;}
        }

        private void Joc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) left = false;
            else if (e.KeyCode == Keys.Right) right = false;
            else if (e.KeyCode == Keys.Up) up = false;
        }

        int inaltime_veche = 300;
        private void timer_aparitie_Tick(object sender, EventArgs e)
        {
            Random rnd_lungime = new Random((int)DateTime.Now.Ticks);
            int lungime = rnd_lungime.Next(210, 420);

            Random rnd_latime = new Random((int)DateTime.Now.Ticks);
            int latime = rnd_latime.Next(75, 100);

            int locatie_veche_subsol = inaltime_veche - 150;
            int locatie_veche_deasupra = inaltime_veche + 100;
            Random rnd_inaltime_aparitie = new Random((int)DateTime.Now.Ticks);
            int inaltime = rnd_inaltime_aparitie.Next(locatie_veche_subsol, locatie_veche_deasupra);
            if (inaltime < 50) inaltime = inaltime + 200;
            if (inaltime > this.Height - 50) inaltime = inaltime - 400;

            PictureBox pb = new PictureBox();
            pb.Width = lungime;
            pb.Height = latime;
            pb.Top = inaltime;
            inaltime_veche = inaltime;
            pb.Left = this.Width;
            pb.BackgroundImage = Platformer_2D.Properties.Resources.platforma_iarba1;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.BackColor = Color.Transparent;

            this.Controls.Add(pb);

            int scor_anterior = int.Parse(lbScor.Text);
            scor_anterior++;
            lbScor.Text = scor_anterior.ToString();
        }

        private void timer_deplasare_stanga_dreapta_Tick(object sender, EventArgs e)
        {
            foreach (var pb in this.Controls.OfType<PictureBox>())
                if (pb != pbBen)
                {
                    pb.Left = pb.Left - 6;
                    if (pb.Left + pb.Width < 0) this.Controls.Remove(pb);
                }

            if (left && up) { pbBen.Top = pbBen.Top - viteza; pbBen.Left = pbBen.Left - viteza; }
            else if (right && up) { pbBen.Top = pbBen.Top - viteza; pbBen.Left = pbBen.Left + viteza; }
            else if (right) pbBen.Left = pbBen.Left + viteza;
            else if (left) pbBen.Left = pbBen.Left - viteza;
            else if (up) pbBen.Top = pbBen.Top - viteza;
        }

        private void timer_cadere_salt_Tick(object sender, EventArgs e)
        {
            cadere = true;
            foreach (var pb in this.Controls.OfType<PictureBox>())
                if (pb != pbBen)
                    if ((pb.Left <= pbBen.Left && pb.Left + pb.Width >= pbBen.Left) || (pb.Left <= pbBen.Left + pbBen.Width && pb.Left + pb.Width >= pbBen.Left + pbBen.Width))
                        if (pbBen.Top + pbBen.Height >= pb.Top && pbBen.Top + pbBen.Height <= pb.Top + 6)
                        {
                            cadere = false;
                        }
            if (cadere == true) { pbBen.Top = pbBen.Top + 5;
                if (up == true) pbBen.BackgroundImage = Platformer_2D.Properties.Resources.salt;
                else pbBen.BackgroundImage = Platformer_2D.Properties.Resources.cazut;
            }

            if (pbBen.Top >= this.Top+this.Height)
            {
                timer_aparitie.Stop();
                timer_cadere_salt.Stop();
                timer_deplasare_stanga_dreapta.Stop();

                pnPierdut.Visible = true;
                int scor_actual = int.Parse(lbScor.Text);
                label2.Text = "Ai pierdut. Scorul tau este " + scor_actual;
                if (scor_actual>HighScore) HighScore = scor_actual;
                
                label3.Text = "Scorul maxim este " + HighScore.ToString();
            }
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            Joc joc = new Joc(HighScore);
            this.Hide();
            joc.ShowDialog();
            this.Close();
        }

        private void timer_schimbare_Tick(object sender, EventArgs e)
        {
            if(cadere==false)
                if (indice_imagine == 1) { pbBen.BackgroundImage = null; pbBen.BackgroundImage = Platformer_2D.Properties.Resources.deplasare1; indice_imagine = 2; }
                else if (indice_imagine == 2) { pbBen.BackgroundImage = null; pbBen.BackgroundImage = Platformer_2D.Properties.Resources.deplasare2; indice_imagine = 1; }
        }

        private void btMeniu_Click(object sender, EventArgs e)
        {
            MeniuPrincipal meniu = new MeniuPrincipal();
            this.Hide();
            meniu.ShowDialog();
            this.Close();
        }

        int perioade_sarite = 0;

        private void timerLimitareSaritura_Tick(object sender, EventArgs e)
        {            
            if(up==true) perioade_sarite++;
            if(perioade_sarite==17) { up = false;perioade_sarite = 0; }
        }
    }
}
