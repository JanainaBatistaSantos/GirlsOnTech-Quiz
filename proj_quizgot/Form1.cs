using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_quizgot
{
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.acertos = 0;
            VariaveisGlobais.erros = 0;
            frmP1 p1 = new frmP1();
            p1.Show();
            this.Hide();
        }
    }
}
