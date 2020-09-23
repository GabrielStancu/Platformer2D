using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer_2D
{
    public partial class MeniuPrincipal : Form
    {
        public MeniuPrincipal()
        {
            InitializeComponent();
        }

        private void btJocNou_Click(object sender, EventArgs e)
        {
            Joc joc = new Joc(0);
            this.Hide();
            joc.ShowDialog();
            this.Close();
        }

        private void btInstructiuni_Click(object sender, EventArgs e)
        {
            Instructiuni instr = new Instructiuni();
            instr.ShowDialog();
        }

        private void btIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
